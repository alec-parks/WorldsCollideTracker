using System.Collections.Generic;
using WorldsCollideTracker.ViewModels;

namespace WorldsCollideTracker.Models
{
    public class DesignModels
    {
        public static Check check => new("Kefka");
        // Magitek Factory, Opera House, South Figaro
        public static Check magitek => new("MagitekFactory");
        public static Check operaHouse => new("OperaHouse");
        public static Check southFigaro => new("SouthFigaro");

        public static List<Check> checks => new()
        {
            magitek, southFigaro, operaHouse
        };

        //TODO Use Celes' actual checks once there's Images.
        public static Character Character => new("Celes", new []{check});

        public static CheckViewModel CheckViewModel = new(check);

        public static GateViewModel GateViewModel = new(Character);
    }
}