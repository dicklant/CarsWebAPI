using Microsoft.AspNetCore.Mvc;
using CarsWebAPI.Data;

namespace CarsWebAPI.Controllers;

[ApiController]
[Route("api/cars")]
public class CarController : ControllerBase {
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCar")]
    public IEnumerable<Car> Get()
    {
        List<Car> cars = new List<Car>();

        cars.Add(new Car() { Modele = "Ami", Marque="Citroen", Puissance=10});
        cars.Add(new Car() { Modele = "MX5", Marque = "Mazda", Puissance = 160 });
        cars.Add(new Car() { Modele = "Scénic", Marque = "Renault", Puissance = 120 });

        return cars.ToArray();
    }

}