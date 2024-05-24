using CabinetMedecin2.Models;
using Microsoft.AspNetCore.Mvc;
using CabinetMedecin2.Models;
using System.Linq;
using CabinetMedecin2.Controllers;
using CabinetMedecin.Data;

public class AccountController : Controller
{
    private readonly GestionDbContext _context;

    public AccountController(GestionDbContext context)
    {
        _context = context;
    }

    // Action pour le formulaire d'inscription
    public IActionResult Register()
    {
        return View();
    }

    // Action pour traiter le formulaire d'inscription
    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Les mots de passe ne correspondent pas.");
                return View(model);
            }

            User user;
            switch (model.Role)
            {
                case "patient":
                    user = new Patient { Email = model.Email, Password = model.Password, Role = model.Role, IsApproved = false };
                    break;
                case "medecin":
                    user = new Medecin { Email = model.Email, Password = model.Password, Role = model.Role, IsApproved = false };
                    break;
                case "assistant":
                    user = new Assistant { Email = model.Email, Password = model.Password, Role = model.Role, IsApproved = false };
                    break;
                default:
                    ModelState.AddModelError(string.Empty, "Rôle d'utilisateur non reconnu.");
                    return View(model);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }

        return View(model);
    }

    // Action pour le formulaire de connexion
    public IActionResult Login()
    {
        return View();
    }

    // Action pour traiter le formulaire de connexion
    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == model.Email && u.Password == model.Password);

            if (user != null)
            {
                if (!user.IsApproved)
                {
                    ModelState.AddModelError(string.Empty, "Votre compte n'a pas encore été approuvé par l'administrateur.");
                    return View(model);
                }

                switch (user.Role)
                {
                    case "patient":
                        return RedirectToAction("PatientDashboard", "Patient");
                    case "medecin":
                        return RedirectToAction("MedecinDashboard", "Medecin");
                    case "assistant":
                        return RedirectToAction("AssistantDashboard", "Assistant");
                    default:
                        ModelState.AddModelError(string.Empty, "Rôle d'utilisateur non reconnu.");
                        return View(model);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Informations d'identification invalides.");
                return View(model);
            }
        }

        return View(model);
    }
}
