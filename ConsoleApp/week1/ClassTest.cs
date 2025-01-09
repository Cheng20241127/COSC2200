
using System.Reflection;
using System.Reflection.Metadata;

namespace ConsoleApp.week1
{
    //static class cannot be initiated as object
    static class UitlFns
    {
        public static void GetAttribute(MemberInfo t)
        {
            // Get instance of the attribute.
            AuthorAttribute? authorAttr = (AuthorAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

            if (authorAttr == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                Console.WriteLine("The name Attribute is: {0}.", authorAttr.name);
                Console.WriteLine("The version Attribute is: {0}.", authorAttr.version);
            }
        }
    }
    internal class ClassTest
    {
        public static void Run(int iCase)
        {
            switch (iCase)
            {
                case 1:
                    {
                        UitlFns.GetAttribute(typeof(Person));
                        var propertyInfo = typeof(Person).GetProperty("FirstName");
                        UitlFns.GetAttribute(propertyInfo);

                        var myClass = new Person();
                        string FirstName = "Cheng";
                        string LastName = "He";
                        using (Person person2 = new Person(FirstName, LastName))
                        {
                            Console.WriteLine($"Dispose of Person will be called when out the scope");
                        }
                    }
                    break;
                case 2:
                    {
                        string FirstName = "Cheng";
                        string LastName = "He";
                        Person person2 = new Person(FirstName, LastName);
                    }
                    break;
            }
        }

    }
}
