namespace CabinetMedecin2.Models
{
    public class Patient
    {
        public int id_patient{ get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public List<RendezVous> RendezVous { get; set; }
        public List<ExamenMedical> ExamensMedicaux { get; set; }
        public List<Procedure> Procedures { get; set; }
        public DossierPatient Dossier { get; set; }
    }
}
