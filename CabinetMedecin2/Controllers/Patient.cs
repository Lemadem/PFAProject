using Microsoft.AspNetCore.Mvc;

namespace CabinetMedecin2.Controllers
{
    public class Patient : Controller
    {
        // Action pour afficher le tableau de bord du patient
        public IActionResult PatientDashboard()
        {
            return View();
        }
    }
}
