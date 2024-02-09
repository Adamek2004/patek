using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public List<BaseRoom> rooms = new();
        public BaseRoom CurrentRoom { get; private set; }

        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();

            lobby.RegisterNeighbour(corridor);


            rooms.AddRange(new BaseRoom[] { lobby, corridor });

            CurrentRoom = rooms[0];
        }

        public string Intro { get; } = @" Procházím touto místností skrz velké ocelové dveře a dostal jsem se do hlavní místnosti celé lodi. Všude kolem mě jsou pracovníci, kteří plní pokyny své povinnosti při letu na Pandoru. Přicházím k oknu a z něj vidím planetu Pandora, která je poměrně ještě dost daleko.

";
    }
}
