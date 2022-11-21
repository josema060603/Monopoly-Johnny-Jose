using NUnit.Framework;

namespace Monopoly.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestBoard()
    {
        Board board = new Board();
        string boardstring = board.GetBoardAsString();
        Assert.AreEqual(boardstring, "");


    }
    [Test]
    public void TestFreeParkingLot()
    {
        // FreeParkingLot freeparkinglot = new FreeParkingLot();
        // string IdOfFreeParkingLot ;
        // Assert.AreEqual(IdOfFreeParkingLot, "Jose");
    }
    [Test]
    public void TestPLayers()
    {
        Player player = new Player("Johnny");
        string playername = "Johnny";
        Assert.AreEqual(playername, player.Name);
        Assert.AreEqual(1500, player.Money);
    }
}