namespace CabinetMedecin2.Models
{
    public class Facture
    {
        public int id_facture { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public Patient PatientAssocie { get; set; }
        public List<ServiceMedical> ServicesMedicaux { get; set; }
    }
}
