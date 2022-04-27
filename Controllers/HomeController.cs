using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetform.Models;

namespace dotnetform.Controllers;

public class HomeController : Controller
{
    public string RequestMethod
    { get; set; }

    public string RequestValues
    { get; set; }
    public void OnPost()
    {
      // For debugging
      RequestMethod = "POST";
      RequestValues = GetFormValues();

    }

    // For debugging
    private string GetFormValues(bool ignoreRequestVerificationToken = true)
    {
      string formData = "";
      string separator = " | ";

      foreach (var pair in this.Request.Form)
      {
        if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
        {
          continue;
        }
        else
        {
          formData += pair.Key + ": " + Request.Form[pair.Key] + separator;
        }
      }

      if (formData.EndsWith(separator))
      {
        formData = formData.Substring(0, formData.Length - separator.Length);
      }

      return formData;
    }


    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
