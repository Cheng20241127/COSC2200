
string currentShow = "week5";
switch (currentShow)
{
    case "week1":
        ConsoleApp.week1.ClassTest.Run(1);
        break;
    case "week3":
        ConsoleApp.week3.ClassTest.Run(2);
        break;
    case "week4":
        ConsoleApp.week4.ClassTest.Run(1);
        //SortedListSample.Test();
        break;
    case "week5":
        ConsoleApp.week5.CustomExceptions.Test("James007");
        //ConsoleApp.week5.CustomExceptions.Test("James");
        //ConsoleApp.week5.DelegateTest.Test();
        break;
    default:
        break;
}
Console.ReadKey();
