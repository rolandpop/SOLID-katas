//Bowling Rules
//The game consists of 10 frames. In each frame the player has two rolls to knock down 10 pins.
//The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.
//A spare is when the player knocks down all 10 pins in two rolls.
//The bonus for that frame is the number of pins knocked down by the next roll.
//A strike is when the player knocks down all 10 pins on his first roll.
//The frame is then completed with a single roll. The bonus for that frame is the value of the next two rolls.
//In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame.
//However no more than three balls can be rolled in tenth frame.
// http://www.butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata
// http://www.butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt

//OCP Rules

//0 Then write a factory that returns an object, or an aggregate of objects, that make the test pass.
//  The factory should be limited to creating objects and linking them together. No conditionals allowed.
//1. Solve the next failing test.
//2. Can you make it pass by changing the factory and/or creating a new class and nothing else?
//  If yes, great! Go back to 1.
//  If not, refactor until you can.

//The refactoring should bring the system to a state where it’s possible to implement the next test just by changing the aggregate of objects that is returned by the factory.
//Be careful not to implement new functionality; the current test should still fail.

namespace BowlingGameKata
{
    public class BowlingGame
    {
        public void Roll(int n) 
        {
        }

        public int Score()
        {
            return -1;
        }
    }
}