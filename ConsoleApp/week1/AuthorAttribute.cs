namespace ConsoleApp.week1
{
    //this Attribute can be apllied to Class, Property
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Property)]
    internal class AuthorAttribute : System.Attribute
    {
        public string name;
        public double version;

        public AuthorAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }
}
