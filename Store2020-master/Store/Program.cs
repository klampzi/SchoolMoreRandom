using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //ask a question
            Console.WriteLine("what's your name?");
            //read answer
            string input = Console.ReadLine();
            //repeat answer
            Console.WriteLine(input + ", really?");
            Console.WriteLine("{0}, really?", input);

            //wait for confirmation to quit
            Console.Write("press enter to exit");
            Console.ReadLine();
            */

            Store st = new Store();
            Console.WriteLine("Welcome to our store! :D");
            st.showcase.Show();

            while (true)
            {
                // buy a game, see what games are there, quit store, see descriptions
                Console.WriteLine("Please enter a command (quit/show/buy)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "quit":
                        Environment.Exit(0);
                        break;

                    case "show":
                        st.showcase.Show();
                        break;

                    case "buy":
                        // ask what game
                        // remove it from showcase
                        //or maybe tell the user that that's not a valid game
                        Console.WriteLine("What game would you like to buy?");
                        
                        string gameToBuy = Console.ReadLine();

                        int gameIndex = Convert.ToInt32(gameToBuy);
                        string gameName = null;
                        if (gameIndex < st.showcase.games.Count)
                        {
                            gameName = st.showcase.games[gameIndex].name;
                        }

                        if (st.showcase.RemoveGame(gameIndex))
                        {
                            Console.WriteLine("Succes, you've brought: " + gameName);
                        }
                        else
                        {
                            Console.WriteLine("You have failed buying anything");
                        }

                        
                        st.showcase.Show();

                        break;

                    default:
                        Console.WriteLine("I don't understand :(");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
