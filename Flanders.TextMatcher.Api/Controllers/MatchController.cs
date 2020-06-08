using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flanders.TextMatcher.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Flanders.TextMatcher.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class MatchController : ControllerBase
    {
        private readonly ILogger<MatchController> _logger;
        private readonly ITextMatcherService _iTextMatcherService;

        public MatchController(ILogger<MatchController> logger, ITextMatcherService iTextMatcherService)
        {
            _logger = logger;
            _iTextMatcherService = iTextMatcherService;
        }

        [HttpGet]
        public IActionResult Get(string text, string subText)   
        {
            return Ok(_iTextMatcherService.Match(text, subText));
        }
    }
}
