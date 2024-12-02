namespace form.Model
{
    public class Osoba
    {
        public string ImieINazwisko { get; set; } = string.Empty;
        public int Wiek { get; set; }
        public string Adres { get; set; } = string.Empty;
        public string Kontakt { get; set; } = string.Empty;

        public string FormatujDane()
        {
            return $"Imię i nazwisko: {ImieINazwisko}, Wiek: {Wiek}, Adres: {Adres}, Kontakt: {Kontakt}";
        }
    }
}
