using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller{
      //GET HW
       public string Index(){
         return "This is my default action...";
       }

       //GET HW Controller

       public string Welcome(){
         return "This is the welcome action method";
       }

       public string Lalala(){
         return "lalalalala route";
       }
    }
}