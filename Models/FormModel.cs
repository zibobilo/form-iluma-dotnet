using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetform.Models;

namespace dotnetform.Models;

  public class FormModel
  {
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    // public void OnPost()
    // {
    //   Console.WriteLine("Hello there");
    // }
  }