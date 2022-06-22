using System.ComponentModel.DataAnnotations;

namespace MiniProjetDotNet.Models
{
    public class Salarie
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "saisissez obligatiorement le Nom")]
        public string Nom { get; set; } = String.Empty;


        [Required(ErrorMessage = "saisissez obligatiorement le Prenom")]
        public string Prenom { get; set; } = String.Empty;


        [Required(ErrorMessage = "saisissez obligatiorement la date de naissance")]
        public DateTime DateNaiss { get; set; }


        [Required(ErrorMessage = "saisissez obligatiorement le numero telephone")]
        [Phone]
        public string Tel { get; set; } = String.Empty;

        [Required(ErrorMessage = "saisissez obligatiorement le numero telephone")]
        public string Email { get; set; } = String.Empty;


        [Required(ErrorMessage = "saisissez obligatiorement l'adresse ")]
        public string Adress { get; set; } = String.Empty;


        public string Image { get; set; } = String.Empty;


        [Required(ErrorMessage = "saisissez obligatiorement la date de recrutement")]
        public DateTime DateRecrutement { get; set; }

    }
}