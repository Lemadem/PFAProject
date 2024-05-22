namespace CabinetMedecin2.Models
{
    public class RendezVous
    {
        public int id_rendezvous { get; set; }
        public DateTime Date { get; set; }
        public string Motif { get; set; }
        public string Statut { get; set; }
        public Patient PatientAssocie { get; set; }
        public PersonnelMedical PersonnelMedicalAssocie { get; set; }
    }
}
