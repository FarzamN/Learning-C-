// // See https://aka.ms/new-console-template for more information

// // strings
// string theGreat = "the greate one the billi sir";

// string newTheGreat = theGreat + " is the best";
// string ReplacedTheGreat = theGreat.Replace("the greate","hellow");
// Console.WriteLine($"here is {ReplacedTheGreat}");

// // strings

// // arrays
// string[] theArray = ["Black rat", "Blue rat","White rat"];

// foreach(var rat in theArray){
//     Console.WriteLine(rat);
// }
//     Console.WriteLine(theArray);

//     Console.WriteLine((int)Warning.codeBlue);
//     enum Warning
//     {
//         codeRed,
//         codeBlue = 3,
//         codeYellow
//     };

/*
var games = "poker";

var result = games switch {
    "chess" => "Chess",
    "lidu" => "Lidu",
    "poker" => "poker",
    _ => "Nothing mathces!"
};

Console.WriteLine(result);
*/

/*

using System.Net.NetworkInformation;

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

while (PR.Status.ToString() == "Success"){
    Console.WriteLine(PR.Status.ToString() + "!");
    PR = p1.Send("8.8.8.8");
    Console.WriteLine("Waitining to seconds for new request");
    Thread.Sleep(10000);
}
*/

/*
using Learning_Csharp;

RealState elmStreet = new(){
    Address = "Street 10 10",
Price = 1000,
SquareFoot = 100
};

var result = elmStreet.CalculatePricePerSquareFoot();
Console.WriteLine(result);
*/

var Tupils = ("t", 2, true, "intiger");
Console.WriteLine(Tupils.Item1 + " " + Tupils.Item2);

var TupilsWithName = (First: "u", sec: 3, Third: false);
Console.WriteLine(TupilsWithName.First);

(int a, string b, bool c) ReturnTheseValue(){
    return (9,"v", true);
}

(int a, string b, bool c) = ReturnTheseValue();
Console.WriteLine(a + "" + b + "" + c);