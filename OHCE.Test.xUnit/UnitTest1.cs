using OHCE.Test.xUnit.Utilities.Builders;
using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit;

public class UnitTest1
{
    [Fact(DisplayName = 
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +
                          "ALORS il est renvoyé " +
                          "ET le <bienDit> de cette langue est envoyé")]
    [InlineData(Expressions.Français.BienDit)]
    [InlineData(Expressions.English.BienDit)]
    public void PalindromeTest(string bienDit)
    {
        // ETANT DONNE un utilisateur parlant <langue>
        var ohce = new OhceBuilder()
            .AyantPourFormuleDeBienDit(bienDit)
            .Build();

        // QUAND on entre un palindrome
        const string palindrome = "kayak";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + bienDit, 
            sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app démarre " +
                          "ALORS <bonjour> de cette langue est envoyé")]
    [InlineData(Expressions.Français.Bonjour)]
    [InlineData(Expressions.English.Bonjour)]
    public void DémarrageTest(string bonjour)
    {
        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder()
            .AyantPourFormuleDeSalutations(bonjour)
            .Build();

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <bonjour> de cette langue est envoyé
        Assert.StartsWith(bonjour, sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app se ferme " +
                          "ALORS <auRevoir> dans cette langue est envoyé")]
    [InlineData(Expressions.English.AuRevoir)]
    [InlineData(Expressions.Français.AuRevoir)]
    public void FermetureTest(string auRevoir)
    {
        var pleinOhce = new OhceGenerator().Generate();

        foreach (var ohce1 in pleinOhce)
        {
            Console.WriteLine();
        }

        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder()
            .AyantPourFormuleDAdieu(auRevoir)
            .Build();

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <auRevoir> dans cette langue est envoyé
        Assert.EndsWith(auRevoir, sortie);
    }
}