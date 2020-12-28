#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["CarRestAPI.WebAPI/CarRestAPI.WebAPI.csproj", "CarRestAPI.WebAPI/"]
COPY ["CarRestAPI.Business/CarRestAPI.Business.csproj", "CarRestAPI.Business/"]
COPY ["CarRestAPI.DataAccess/CarRestAPI.DataAccess.csproj", "CarRestAPI.DataAccess/"]
COPY ["CarRestAPI.Entities/CarRestAPI.Entities.csproj", "CarRestAPI.Entities/"]
COPY ["CarRestAPI.Core/CarRestAPI.Core.csproj", "CarRestAPI.Core/"]
RUN dotnet restore "CarRestAPI.WebAPI/CarRestAPI.WebAPI.csproj"
COPY . .
WORKDIR "/src/CarRestAPI.WebAPI"
RUN dotnet build "CarRestAPI.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarRestAPI.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://*:4550
ENTRYPOINT ["dotnet", "CarRestAPI.WebAPI.dll"]