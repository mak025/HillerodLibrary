
using HillerodLibrary.Models;

namespace HillerodLibrary.Interface
{
    public class BoatCollection : IBoat
    {
        private List<Boat> _boats;

        public BoatCollection()
        {
            _boats = new List<Boat>();
            Seed();
        }

        private void Seed()
        {
            _boats.Add(new SailBoat("sailboat", "small", 6, "fiberglas", "alle sammen", 80, 2012, "Jytte", "JYT50425034", "Main Sail", 1, true));
            _boats.Add(new SailBoat("sailboat", "small", 6, "fiberglas", "alle sammen", 80, 2012, "Jette", "JYT50423545", "Main Sail", 1, true));
            _boats.Add(new SailBoat("sailboat", "small", 6, "fiberglas", "alle sammen", 80, 2012, "Janne", "JYT50487536", "Main Sail", 1, true));
            _boats.Add(new SailBoat("sailboat", "small", 6, "fiberglas", "alle sammen", 80, 2012, "Jonne", "JYT50429737", "Main Sail", 1, true));
            _boats.Add(new MotorBoat("Motorboar", "medium", 12, "fiberglass", "blue", 123, 2010, "Fatty", "FAT87563737", 120, "potatoes", 6));
        }

    }
}
