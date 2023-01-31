using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.Bonjour)]
        public void BonjourTest(PeriodeJournee periode, string salutationAttendue)
        {
            var langue = new LangueFrançaise();
            var salutation = langue.Bonjour(periode);
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.auRevoirSoir)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.AuRevoir)]
        public void AuRevoirTest(PeriodeJournee periode, string salutationAttendue)
        {
            var langue = new LangueFrançaise();
            var auRevoir = langue.AuRevoir(periode);
            Assert.Equal(salutationAttendue, auRevoir);
        }
    }
}