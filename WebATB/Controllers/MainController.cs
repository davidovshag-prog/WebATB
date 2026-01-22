using Microsoft.AspNetCore.Mvc;
using WebATB.Models.Users;

namespace WebATB.Controllers;

public class MainController : Controller
{
    public IActionResult Index()
    {
        List<UserItemModel> model = new List<UserItemModel>();

        model.Add(new UserItemModel
        {
            Id = 1,
            Name = "Підкаблучник Марко Йосипович",
            Phone = "+38(098)235 6421",
            Image = "1.jpg"
        });

        model.Add(new UserItemModel
        {
            Id = 2,
            Name = "Рижий Олексій Мохнович",
            Phone = "+38(098)224 6165",
            Image = "2.jpg"
        });

        model.Add(new UserItemModel
        {
            Id = 3,
            Name = "Галоша Іванна Ігорівна",
            Phone = "+38(098)378 4756",
            Image = "3.jpg"
        });

        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(UserItemModel model, IFormFile imageFile)
    {
        return RedirectToAction("Index");
    }

}
