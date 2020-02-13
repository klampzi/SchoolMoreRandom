using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        public Showcase showcase;

        public Store()
        {
            showcase = new Showcase(5);
            Game g1 = new Game("Braid", "timeywimey puzzle game", 10);
            Game g2 = new Game("Warcraft 3", "bad cash grab", 40);
            Game g3 = new Game("Doom", "demon bad, pewpew", 1);
            //we need to add games to the showcase
            showcase.AddGame(g1);
            showcase.AddGame(g2);
            showcase.AddGame(g3);

            DLC d1 = new DLC("Frozen Throne", "more warcraft 3", 100);
            g2.dlcs.Add(d1);
        }

        //buying
        //seeing what for sale

    }
}
