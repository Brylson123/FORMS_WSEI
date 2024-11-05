namespace Forms.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Dane
    {
        [Required(ErrorMessage = "Proszę podaj imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string? Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string? Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podaj adres e-mail")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i cyfrę")]
        public string? Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdź hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        public string? PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [Phone(ErrorMessage = "Nieprawidłowy format numeru telefonu")]
        public string? NrTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podać wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być pomiędzy 11 a 80 lat")]
        public int? Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybierz miasto")]
        public string? Miasto { get; set; }

        public enum Miasta { Łódź, Kraków, Toruń, Gdańsk, Poznań }
    }
}
