using System;
using Abstracao_RPG_POO.src.Entities;

class Program {
    static void Main() {
        Knight Arus = new Knight("Arus", 12, "Knight", 469, 769, 72, 72);
        Wizard Jennica = new Wizard("Jennica", 15, "White Wizard", 325, 601, 474, 482);
        Wizard Topapa = new Wizard("Topapa", 20, "Black Wizard", 106, 385, 611, 641);
        Ninja Wedge = new Ninja("Wedge", 18, "Ninja", 292, 574, 89, 89);

        Console.WriteLine("--------------");
        Console.WriteLine(Jennica);
        Console.WriteLine("--------------");
        Console.WriteLine(Arus);
        Console.WriteLine("--------------");
        Console.WriteLine(Topapa);
        Console.WriteLine("--------------");
        Console.WriteLine(Wedge);
        Console.WriteLine("--------------");
    }
}