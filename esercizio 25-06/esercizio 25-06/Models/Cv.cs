namespace esercizio_25_06.Models
{
    public class Cv
    {
        public InformazioniPersonali  InformazioniPersonali;

        public Studi  Studi;

        public Impieghi  Impieghi; 

        public Cv()
        {
            InformazioniPersonali = new InformazioniPersonali();
            Studi = new Studi();
            Impieghi = new Impieghi();
        }
       
    }
}
