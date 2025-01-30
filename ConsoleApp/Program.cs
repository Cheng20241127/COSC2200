
using ConsoleApp.week4;

string currentShow = "week4";
switch (currentShow)
{
    case "week1":
        ConsoleApp.week1.ClassTest.Run(1);
        break;
    case "week3":
        ConsoleApp.week3.ClassTest.Run(2);
        break;
    case "week4":
        SortedListSample.Test();
        break;
    default:
        break;
}
