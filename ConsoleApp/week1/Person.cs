
namespace ConsoleApp.week1
{
    [Author("Cheng He", version = 1.1)]
    public class Person : IDisposable, IComparable
    {
        //Constructor Chaining
        public Person() : this("Mark", "Bertschy", 48)
        { }
        private bool disposed = false;
        private string lname = string.Empty;
        [Author("Randy Fraser", version = 2.1)]
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Person(string firstName, string lastName, int iage = 0)
        {
            FirstName = firstName;
            lname = lastName;
            Age = iage;
            //Console.WriteLine($"{this} is constructed");
        }
        //.net doesn't have delete to call Destructor
        //Finalizer is generally called by the garbage collector 
        //whenever the reference of any object is not used for a long time.
        ~Person()
        {
            Console.WriteLine($"Release managed resources of {this} in Destructor");
            Dispose(false);
        }
        //.net has no delete operator, so it provides Dispose
        //Dispose, which won't be called by GC, need to explicitly called
        public void Dispose()
        {
            Console.WriteLine($"We need to Suppress GC from calling destructor of {this}");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Free any managed objects here ...");
                }
                Console.WriteLine("Free any unmanaged objects here ...");
                disposed = true;
            }
        }
        public override string ToString()
        {
            return $"FirstName:{FirstName}\tAge:{Age}";
        }
        public static bool operator >(Person a, Person b) => a.Age > b.Age;
        public static bool operator <(Person a, Person b) => a.Age < b.Age;
        //we should not override ==, as it is used for reference comparison
        public static bool operator ==(Person a, Person b)
        {
            if (b is null) return false;
            return a.Age == b.Age;
        }
        public static bool operator !=(Person a, Person b) => a.Age != b.Age;
        //this is object member function, this is .net style compare two objects
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            Person? objTarget = obj as Person;
            if (objTarget is null) return false;
            return this == objTarget;
        }
        public override int GetHashCode()
        {
            string strContent = $"{FirstName}{lname}{Age}";
            return strContent.GetHashCode();
        }
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is not Person objPerson || this > objPerson) return 1;
            else if (this == objPerson) return 0;
            else return -1;
        }
    }
}
