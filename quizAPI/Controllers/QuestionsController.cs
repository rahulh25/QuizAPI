using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        readonly QuizContext context;
        public QuestionsController(QuizContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {

            return new Models.Question[]
            {
                new Models.Question(){Text="test"},
                new Models.Question(){Text="test2"},
            };
        }
        [HttpPost]
        public void Post([FromBody]Models.Question question)
        {
            context.Questions.Add(new Models.Question() { Text="test Context"});
        }
    }
}