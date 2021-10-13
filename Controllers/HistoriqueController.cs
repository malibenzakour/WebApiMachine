using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiMachine.Models;
using WebApiMachine.Repositories;

namespace WebApiMachine.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HistoriqueController : ControllerBase
    {
        private readonly IHistoriqueRepository _historiqueRepository;

        private readonly ILogger<HistoriqueController> _logger;


        public HistoriqueController(IHistoriqueRepository historiqueRepository, ILogger<HistoriqueController> logger)
        {
            _logger = logger;
            _historiqueRepository = historiqueRepository;
        }

        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Historique))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Post(string id)
        {
            _logger.LogInformation("\n\n\nstream\n\n\n");

            var result = _historiqueRepository.Post(id);

            if (result)
            {
                return Ok(result);
            }

            return NotFound();

        }
    }
}
