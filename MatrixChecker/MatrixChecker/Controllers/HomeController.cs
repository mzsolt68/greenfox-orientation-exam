using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatrixChecker.Models;
using MatrixChecker.Services;
using MatrixChecker.ViewModels;

namespace MatrixChecker.Controllers
{
    public class HomeController : Controller
    {
        IMatrixService matrixService;
        MatrixViewModel matrixViewModel;

        public HomeController(IMatrixService service)
        {
            matrixService = service;
            matrixViewModel = new MatrixViewModel();
        }

        public IActionResult Index()
        {
            if(TempData["input"] != null && TempData["result"] != null)
            {
                matrixViewModel.Data = (string)TempData["input"];
                matrixViewModel.Result = (string)TempData["result"];
            }
            return View(matrixViewModel);
        }

        [HttpPost("/matrix")]
        public IActionResult TestMatrix(string input)
        {
            TempData["input"] = input;
            TempData["result"] = matrixService.CheckMatrix(input);
            //TempData["datas"] = matrixViewModel;
            return RedirectToAction("Index");
        }

        [HttpGet("/matrices")]
        public IActionResult ListMatrices()
        {
            return Json(matrixService.GetAllMatrices());
        }
    }
}
