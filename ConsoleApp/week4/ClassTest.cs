

namespace ConsoleApp.week4
{

    internal partial class ClassTest
    {
        public static void Run(int iCase)
        {
            switch (iCase)
            {
                case 1:
                    ConsoleApp.week4.DataAccess objData = new ConsoleApp.week4.DataAccess();
                    //objData.Save2("");
                    //However, if you want to call the interface method using a class object,
                    //you need to cast it to the interface type. Here’s how you can do it:
                    ((IDataAccessObject)objData).Save2("");
                    break;
                case 2: //implement interface
                    DataAccess.Test();
                    break;
            }
        }

    }
}
