using CarRestAPI.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRestAPI.Entities.Concrete
{
    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public decimal CarPrice { get; set; }
    }
}
