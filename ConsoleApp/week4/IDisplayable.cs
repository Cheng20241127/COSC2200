namespace ConsoleApp.week4
{
    public interface IDisplayable {
        // add additional members here
        //public int dataMember = 0; we cannot have fields in Interface
        //int privateData = 0;
        int DataMember { get; set; }
        string GetDisplayText(string sep) => ToString() + sep; 
    }
    public interface IPersistable
    {
        object Read(string id);
        bool Save(string id);
        bool HasChanges { get; set; }
    }
    public interface IDataAccessObject : IDisplayable, IPersistable
    {
        //interface can have default member implementation
        bool Save2(string id)
        {
            return false;
        }
    }
    public abstract class Access
    {
        public abstract bool AbtFunction();
        public bool ImpFunction() { return true; }
    }
    public class DataAccess : Access, IDataAccessObject
    {
        int IDisplayable.DataMember { get ; set ; }//no default implementation on data property
        bool IPersistable.HasChanges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool AbtFunction()
        {
            return false;
        }

        object IPersistable.Read(string id)
        {
            return null;
        }
        bool IPersistable.Save(string id)
        {
            return false;
        }
        public static void Test()
        {
            DataAccess obj = new DataAccess();
            ((IPersistable)obj).Read(""); //we need to cast to interface to access its members
            obj.AbtFunction();
            obj.ImpFunction();//no need to cast to parent class to access its members
        }
    }


}
