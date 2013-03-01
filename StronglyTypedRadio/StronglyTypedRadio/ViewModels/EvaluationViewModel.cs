using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels
{
    public class Question
    {
        public int ID { set; get; }
        public string QuestionText { set; get; }
        public List<Answer> Answers { set; get; }
        [Required]
        public string SelectedAnswer { set; get; }
        public Question()
        {
            Answers = new List<Answer>();
        }
    }
    public class Answer
    {
        public int ID { set; get; }
        public string AnswerText { set; get; }
    }
    public class Evaluation
    {
        public List<Question> Questions { set; get; }
        public Evaluation()
        {
            Questions = new List<Question>();
        }
    }
}