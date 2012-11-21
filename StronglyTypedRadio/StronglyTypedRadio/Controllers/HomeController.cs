using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace StronglyTypedRadio.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var evalVM = new Evaluation();

            //the below is hardcoded for DEMO. you may get the data from some  
            //other place and set the questions and answers

            var q1 = new Question { ID = 1, QuestionText = "What is your favourite language" };
            q1.Answers.Add(new Answer { ID = 12, AnswerText = "PHP" });
            q1.Answers.Add(new Answer { ID = 13, AnswerText = "ASP.NET" });
            q1.Answers.Add(new Answer { ID = 14, AnswerText = "Java" });
            evalVM.Questions.Add(q1);

            var q2 = new Question { ID = 2, QuestionText = "What is your favourite DB" };
            q2.Answers.Add(new Answer { ID = 16, AnswerText = "SQL Server" });
            q2.Answers.Add(new Answer { ID = 17, AnswerText = "MyQL" });
            q2.Answers.Add(new Answer { ID = 18, AnswerText = "Oracle" });
            evalVM.Questions.Add(q2);

            return View(evalVM);           
        }

      
        [HttpPost]
        public ActionResult Index(Evaluation model)
        {
            if (ModelState.IsValid)
            {
                foreach (var q in model.Questions)
                {
                    var qId = q.ID;
                    var selectedAnswer = q.SelectedAnswer;
                    // Save the data 

                }
                return RedirectToAction("ThankYou"); //PRG Pattern
            }
            //reload questions
            return View(model);
        }





        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
