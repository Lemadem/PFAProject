using Microsoft.AspNetCore.Mvc;

namespace CabinetMedecin2.Controllers
{
    public class Medecin : Controller
    {
        // Action pour afficher le tableau de bord du médecin
        public IActionResult MedecinDashboard()
        {
            return View();
        }
    }

}
