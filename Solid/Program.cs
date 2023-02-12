// See https://aka.ms/new-console-template for more information
using SOLID.LSP.With;
using SOLID.LSP.Without;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

#region LSP

//This does not follow LSP because the Orange class could not replace the Apple class without altering the program output.
//The GetColor() method is overridden by the Orange class and therefore would return that an apple is orange.

Apple1 apple = new Orange1();
Debug.WriteLine(apple.GetColor());

//Now, any subtype (Apple or Orange) of the Fruit class can be replaced with the other subtype without error thanks to the class-specific behavior of GetColor().
//As a result, this program now achieves the LSP principle.

Fruit fruit = new Orange();
Debug.WriteLine(fruit.GetColor());
fruit = new Apple();
Debug.WriteLine(fruit.GetColor());

#endregion