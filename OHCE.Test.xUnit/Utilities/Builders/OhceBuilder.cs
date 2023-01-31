using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private ILangue _langue = new LangueMock();
        private PeriodeJournee _periodeJournee = PeriodeJournee.Defaut;

        public static Ohce Base => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue, _periodeJournee);

        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }

        public OhceBuilder AyantPourPeriodeDeLaJournee(PeriodeJournee periode)
        {
            _periodeJournee = periode;
            return this;
        }
    }
}