namespace CabinetMedecin2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; } // "patient", "medecin", "assistant"
        public bool IsApproved { get; set; } // Approuvé par l'administrateur
    }

}
