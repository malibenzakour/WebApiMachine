using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiMachine.Models;
using WebApiMachine.Repositories;

namespace WebApiMachine.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        private readonly ILogger<ArticlesController> _logger;


        public ArticlesController(IArticleRepository articleRepository, ILogger<ArticlesController> logger)
        {
            _logger = logger;
            _articleRepository = articleRepository;
        }

        [HttpGet("{type}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public  ActionResult<IList<Article>> GetArticles(string type)
        {
            _logger.LogInformation("\n\n\nstream\n\n\n");

            var result =  _articleRepository.Get(type).ToList();

            if (result.Any())
            {
                return Ok(result);
            }

            return NotFound();

        }
    }
}