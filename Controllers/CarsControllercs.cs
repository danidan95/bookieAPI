using bookieAPI.DTOs;
using bookieAPI.Models;
using bookieAPI.Repositories.CarRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookieAPI.Controllers
{

    [ApiController]
    public class CarsControllercs : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarsControllercs(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost]
        [Route("/Car/Create")]
        public IActionResult Create([FromForm] Car car)
        {
            return Ok(_carRepository.Create(car));
        }

        [HttpGet]
        [Route("/Car/Model")]
        public IActionResult Model([FromQuery] Car car)
        {
            return Ok(_carRepository.Model(car));
        }

    }
}
