using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using quizAPI.Models;

namespace quizAPI
{
    public class QuizContext: DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options): base(options){ }
        
        public DbSet<Models.Question> Questions { get; set; }
        
        public DbSet<quizAPI.Models.Quiz> Quiz { get; set; }
        
    }
}
