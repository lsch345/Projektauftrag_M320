using ProjektM320;
namespace RouletteTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PlaceBet_MitGueltigemBetrag_BerechnetKontostandRichtig()
    {
        // Arrange
        int anfangsStand = 1000;
        int betrag = 200;
        int expected = 800; // Erwarteter Kontostand nach Platzieren der Wette
        Player player = new Player("Noah", anfangsStand);

        // Act
        player.PlaceBet(new NumberBet(betrag, 5));

        // Assert
        int actual = player.Balance;
        Assert.AreEqual(expected, actual, "Kontostand wurde nicht korrekt aktualisiert.");
    }
    
    [TestMethod]
    public void Evaluate_MitRichtigerFarbe_GibtTrueZurueck()
    {
        // Arrange
        int result = 3; // 3 ist ungerade, also "Red"
        ColorBet bet = new ColorBet(100, "Red");

        // Act
        bool actual = bet.Evaluate(result);

        // Assert
        Assert.AreEqual(true, actual, "Farbe wurde nicht korrekt ausgewertet.");
    }


}