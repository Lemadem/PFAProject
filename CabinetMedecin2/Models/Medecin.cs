namespace CabinetMedecin2.Models
{
    public class Medecin
    {
        
            public int MedecinId { get; set; }
            public string Nom { get; set; }
            public string Specialite { get; set; }
            // Autres propriétés spécifiques au médecin

            public void ConsulterDossierPatient(Patient patient)
            {
                // Logique pour consulter le dossier du patient
            }

            public void PrescrireMedicament(Patient patient, string medicament)
            {
                // Logique pour prescrire un médicament au patient
            }
        }

    }

