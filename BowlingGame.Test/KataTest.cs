using Shouldly;

namespace BowlingGameKata.Test
{
    public class KataTest
    {

        [Fact]
        public void GutterGameTest()
        {
            BowlingGame game = new BowlingGameFactory().Create();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            game.Score().ShouldBe(0);
        }

        [Fact]
        public void AllOnesGameTest()
        {
            BowlingGame game = new BowlingGameFactory().Create();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }
            game.Score().ShouldBe(20);
        }

        [Fact]
        public void OneSpareTest()
        {
            BowlingGame game = new BowlingGameFactory().Create();
            game.Roll(5);
            game.Roll(5); // spare
            game.Roll(3);
            for (int i = 0; i < 17; i++)
            {
                game.Roll(0);
            }

            game.Score().ShouldBe(16);
        }

        [Fact]
        public void OneStrikeTest()
        {
            BowlingGame game = new BowlingGameFactory().Create();
            game.Roll(10); // strike
            game.Roll(3);
            game.Roll(4);
            for (int i = 0; i < 16; i++)
            {
                game.Roll(0);
            }

            game.Score().ShouldBe(24);
        }

        [Fact]
        public void PerfectGameTest()
        {
            BowlingGame game = new BowlingGameFactory().Create();
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }

            game.Score().ShouldBe(300);
        }

    }
}