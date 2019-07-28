using BattleshipTDD.Game;
using Shouldly;
using Xunit;

namespace BattleshipTDD.Tests
{
    public class BoardShould
    {
        [Fact]
        public void DisplaySize()
        {
            var board = new Board("Normal");

            board.Size.ShouldBe("Pretty Big");
        }
    }
}
