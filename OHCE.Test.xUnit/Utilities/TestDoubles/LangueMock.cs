namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;
        public string Bonjour(PeriodeJournee periode) => string.Empty;
        public string AuRevoir(PeriodeJournee periode) => string.Empty;
        public string useLanguage { get; init; } = string.Empty;
        public string enterString { get; init; } = string.Empty;
        public string reverseWord { get; init; } = string.Empty;

        public string periode { get; init; } = string.Empty;
    }
}