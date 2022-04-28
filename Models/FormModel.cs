using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetform.Models;

namespace MvcForm.Models;

  public class FormModel
  {
    string? FirstName
    { get; set; }

    string? LastName
    { get; set; }

    public void OnPost()
    {
      Console.WriteLine("Hello there");
    }
  }