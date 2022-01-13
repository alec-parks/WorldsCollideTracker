using System.Collections.Generic;
using WorldsCollideTracker.ViewModels;

namespace WorldsCollideTracker.Models
{
    public class DesignModels
    {
        public static Check Check => new("Kefka");
        // Magitek Factory, Opera House, South Figaro
        public static Check Magitek => new("MagitekFactory");
        public static Check OperaHouse => new("OperaHouse");
        public static Check SouthFigaro => new("SouthFigaro");

        public static List<Check> Checks => new()
        {
            Magitek, /*SouthFigaro,*/ OperaHouse
        };

        public static Character Character => new("Celes", Checks);

        public static CheckViewModel CheckViewModel = new(Check);

        public static GateViewModel GateViewModel = new(Character);
    }
}