namespace CabinetMedecin2.Models
{
    public class Procedure
    {
        public int id_proceure { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Patient PatientAssocie { get; set; }
    }
}
