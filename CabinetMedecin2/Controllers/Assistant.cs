using Microsoft.AspNetCore.Mvc;

namespace CabinetMedecin2.Controllers
{
    public class Assistant : Controller
    {
        // Action pour afficher le tableau de bord de l'assistante
        public IActionResult AssistantDashboard()
        {
            return View();
        }
    }

}
