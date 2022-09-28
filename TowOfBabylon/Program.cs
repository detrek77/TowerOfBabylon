using TowOfBabylon;
using TowOfBabylon.Models;

var boxArray = new Box[1];
boxArray[0] = new Box() { Depth = 14, Height = 27, Width = 78 };

var maxHeight = BoxStackCalculator.CalculateMaxStackHeight(boxArray);

Console.WriteLine($"Max Height: {maxHeight}");
