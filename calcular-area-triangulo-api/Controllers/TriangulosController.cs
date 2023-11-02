using Microsoft.AspNetCore.Mvc;

namespace calcular_area_triangulo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangulosController : ControllerBase
    {
        [HttpGet("calcular-triangulos")]
        public String calcularTriangulos(Int16 valorBase, Int16 valorAltura)
        {
            return (valorBase * valorAltura / 2).ToString();
        }
    }
}
