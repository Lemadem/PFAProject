namespace CabinetMedecin2.Models
{
    public class Paiement
    {
        public int id_paiement { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string ModePaiement { get; set; }
        public Facture FactureAssociee { get; set; }
    }
}
