namespace CabinetMedecin2.Models
{
    public class ExamenMedical
    {
        public int id_examen {get;set;}
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Resultat { get; set; }
        public Patient PatientAssocie { get; set; }
    }
}
