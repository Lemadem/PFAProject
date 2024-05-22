namespace CabinetMedecin2.Models
{
    public class Assistante
    {
      
            public int AssistantId { get; set; }
            public string Nom { get; set; }
            public string Poste { get; set; }
            // Autres propriétés spécifiques à l'assistante

            public void PlanifierRdv(Patient patient, DateTime dateRdv)
            {
                // Logique pour planifier un rendez-vous pour un patient
            }

            public void EnregistrerPaiement(Patient patient, decimal montant)
            {
                // Logique pour enregistrer un paiement pour un patient
            }
        }
    }
