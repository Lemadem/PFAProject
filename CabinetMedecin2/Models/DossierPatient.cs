namespace CabinetMedecin2.Models
{
    public class DossierPatient
    {
        public int id_dossier { get; set; }
        public DateTime DateCreation { get; set; }
        public string AntecedentsMedicaux { get; set; }
        public string Ordonnances { get; set; }
        public string ResultatsExamens { get; set; }
    }
}
