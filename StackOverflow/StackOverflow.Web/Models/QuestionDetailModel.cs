using System;
using System.ComponentModel.DataAnnotations;
using StackOverflow.Domain.Entities;

namespace StackOverflow.Web.Controllers
{
    public class QuestionDetailModel
    {
        public string Title { get; set; }
        public string Decription { get; set; }
        public Account Owner { get; set; }
        public int Answers { get; set; }
        public int Votes { get; set; }
        public int Views { get; set; }
        [Required(ErrorMessage = "mierdaaa")]
        public string CreateAnswer { get; set; }
        [Required]
        public string CreateComment { get;set; }
        public Guid QuestionId { set; get; }

    }
}