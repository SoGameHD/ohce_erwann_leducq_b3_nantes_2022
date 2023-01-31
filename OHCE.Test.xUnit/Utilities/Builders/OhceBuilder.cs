using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private ILangue _langue = new LangueMock();

        public static Ohce Base => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue);

        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }
    }
}