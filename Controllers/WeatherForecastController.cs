using Microsoft.AspNetCore.Mvc;

namespace WebApiSemana4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("DevolverSuma/{Numero1}/{Numero2}")]
        public int DevolverSuma(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }

        [HttpGet("DevolverResta/{Numero1}/{Numero2}")]
        public int DevolverResta(int Numero1, int Numero2)
        {
            return Numero1 - Numero2;
        }

        [HttpGet("saludo/{nombre}")]
        public string saludo(string nombre)
        {
            return "Hola Mundo de "  +nombre;
        }

        [HttpGet("DevolverValor")]
        public int DevolverValor()
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;
            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num3;
        }

        [HttpGet("DevolverSaludo")]
        public string DevolverSaludo()
        {
            string variable1 = "Pedro";
            string variable2 = "Juan";
            string variable3 = variable1 + variable2;
            int num1 = 7;
            string variable4 = variable3 + num1;
            string mensaje = "Hola " + variable4;
            return mensaje;
        }

        [HttpGet("DevolverMayor/{num1}/{num2}")]
        public string DevolverMayor(int num1, int num2)
        {
            if(num1 > num2)
            {
                return "El mayor es " + num1.ToString();
            }
            else
            {
                return "El mayor es " + num2.ToString();
            }
           
        }

        [HttpGet("DevolverEstado/{edad}/{Nombre}")]
        public string DevolverEstado(int edad, string Nombre)
        {
            string mensaje = "";
            if (edad >=18)
            {
                mensaje = "Sr.(a) " + Nombre + " es mayor de edad";
            }
            else
            {
                mensaje = "Sr.(a) " + Nombre + " es menor de edad";
            }
            return mensaje;
        }

        [HttpGet("CalcularArea/{largo}/{ancho}")]
        public string CalcularArea(int largo, int ancho)
        {
            int area = largo * ancho;

            string mensaje = "Su area es " + area;

            return mensaje;
        }


        [HttpGet("CalcularEdad/{n}/{a}")]
        public string CalcularEdad(string n, int a)
        {
            int e = 2024 - a;
            return "Sr. " + n + " su edad es " + e + " años";
        }

        [HttpGet("CalcularGeneracion/{a}")]
        public string CalcularGeneracion(int a)
        {
            if (a >= 1997 && a <= 2012)
            {
                return "Usted es de la generación Z";
            }
            else
            {
                return "Usted no es de la generación Z";
            }
        }

        [HttpGet("DevolverAlumno")]
        public string DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan","Perez","45263547");
            return Alumno2.DevolverNombreCompleto();
        }

        [HttpGet("DevolverDocumento")]
        public string DevolverDocumento()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "45263547");
            return Alumno2.DevolverDocumento();
        }

        [HttpGet("DevolverEdad")]
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Anthony", "Herrera", "45263547", new DateTime(1999,11,1));
            return Alumno3.DevolverEdad();
        }
    }
}