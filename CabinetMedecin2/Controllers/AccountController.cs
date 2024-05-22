using CabinetMedecin2.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // Action pour le formulaire de connexion
    public IActionResult Login()
    {
        return View();
    }

    // Action pour traiter le formulaire de connexion
    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        // Vérifiez ici les informations d'identification de l'utilisateur (par exemple, dans une base de données)

        // Exemple de vérification basique (à remplacer par votre logique de vérification réelle)
        if (model.Email == "patient" && model.Password == "password_patient")
        {
            // Redirection vers la page du patient
            return RedirectToAction("PatientDashboard", "Patient");
        }
        else if (model.Email == "medecin" && model.Password == "password_medecin")
        {
            // Redirection vers la page du médecin
            return RedirectToAction("MedecinDashboard", "Medecin");
        }
        else if (model.Email == "assistante" && model.Password == "password_assistante")
        {
            // Redirection vers la page de l'assistante
            return RedirectToAction("AssistantDashboard", "Assistant");
        }
        else
        {
            // Si les informations d'identification sont incorrectes, affichez un message d'erreur
            ModelState.AddModelError(string.Empty, "Informations d'identification invalides.");
            return View(model);
        }
    }
}
