using System.Collections.Generic;
using WorldsCollideTracker.ViewModels;

namespace WorldsCollideTracker.Models
{
    public class DesignModels
    {
        public static Check check => new("Kefka", true);
        // Magitek Factory, Opera House, South Figaro
        public static Check magitek => new("MagitekFactory");
        public static Check operaHouse => new("OperaHouse");
        public static Check southFigaro => new("SouthFigaro");

        public static List<Check> checks => new()
        {
            magitek, southFigaro, operaHouse
        };

        public static Character character => new("Celes", checks, true);

        public static CheckViewModel CheckViewModel = new(check);

        public static GateViewModel GateViewModel = new(character);
    }
}