using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/checkword")]
        public ActionResult CheckWord()
        {

            string searchWord = Request.Form["word"];
            string phrase = Request.Form["phrase"];
            int count = WordModel.CountWords(searchWord, phrase);

            WordModel Model = new WordModel(searchWord, phrase, count);

            return View(Model);
        }
    }
}
