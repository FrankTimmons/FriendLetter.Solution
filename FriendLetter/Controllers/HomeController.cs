using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Location = "Portland";
      myLetterVariable.IdealLocation = "Mexico";
      myLetterVariable.Souvenir = "Taco";
      return View(myLetterVariable);
    }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string idealLocation, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.IdealLocation = idealLocation;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}