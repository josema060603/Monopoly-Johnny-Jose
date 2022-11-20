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
        FreeParkingLot freeparkinglot = new FreeParkingLot();
        string IdOfFreeParkingLot = freeparkinglot.Id = "Jose";
        Assert.AreEqual(IdOfFreeParkingLot, "Jose");
    }
    [Test]
    public void TestPLayers()
    {
        Player player = new Player();
        string playername = player.name = "Johnny";
        string playersmoney = player.Money = 2500;
        Assert.AreEqual(playersname, "Johnny");
        Assert.AreEqual(playersmoney, 2500);
    }
}