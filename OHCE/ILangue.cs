namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string Bonjour(PeriodeJournee periode);
        string AuRevoir(PeriodeJournee periode);
        string useLanguage { get; }
        string reverseWord { get; }
        string enterString { get; }
        string periode { get; }

    }
}
