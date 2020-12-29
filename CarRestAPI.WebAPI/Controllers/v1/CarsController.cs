using CarRestAPI.Business.Abstract;
using CarRestAPI.Entities.Concrete;
using CarRestAPI.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRestAPI.WebAPI.Controllers.v1
{
    [ApiVersion(V.v1_0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    
    public class CarsController : ControllerBase
    {
        private ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        /// <summary>
        /// Get the list of all Cars
        /// </summary>
        /// <remarks>
        /// Long description of GET /cars, maybe with an sample request or user case. 
        /// </remarks>
        /// <returns>List of Cars</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult GetList()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Get the Cars with id
        /// </summary>
        /// <remarks>
        /// Long description of GET /cars/id, maybe with an sample request or user case. 
        /// </remarks>
        /// <returns>List of Cars</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Add a new car
        /// </summary>
        /// <remarks>
        /// Long description of POST /add, maybe with an sample request or user case. 
        /// </remarks>
        /// <returns>List of Cars</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("add")]
        public IActionResult Add([FromBody] Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(JsonConvert.SerializeObject(result.Message));
            }
            return BadRequest(result.Message);
        }


        /// <summary>
        /// Update a car that already exists
        /// </summary>
        /// <remarks>
        /// Long description of PUT /update, maybe with an sample request or user case. 
        /// </remarks>
        /// <returns>List of Cars</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPut("update")]
        public IActionResult Update([FromBody] Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(JsonConvert.SerializeObject(result.Message));
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Delete a given car
        /// </summary>
        /// <remarks>
        /// Long description of POST /delete, maybe with an sample request or user case. 
        /// </remarks>
        /// <returns>List of Cars</returns>
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(JsonConvert.SerializeObject(result.Message));
            }
            return BadRequest(result.Message);
        }
    }
}
