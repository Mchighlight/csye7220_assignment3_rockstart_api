using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace rockstar_api.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        private Music myMusic = new Music();

        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/TestHealth")]
        public String Get() {
            return "<h1>My Jukebox!</h1>";
        }

        [HttpGet]
        [Route("[controller]/Stronger")]
        public String GetStronger(){
            return myMusic.Stronger ;
        }

        [HttpGet]
        [Route("[controller]/BonitaApplebum")]
        public String GetBonitaApplebum(){
            return myMusic.BonitaApplebum ;
        }

        [HttpGet]
        [Route("[controller]/DayAndNight")]
        public String GetDayAndNight(){
            return myMusic.DayAndNight ;
        }
    }
}
