namespace ConsoleApp.week4
{
    public interface IDisplayable { string GetDisplayText(string sep) => ToString() + sep; }
    public interface IPersistable
    {
        object Read(string id);
        bool Save(object o);
        bool HasChanges { get; set; }
    }
    public interface IDataAccessObject : IDisplayable, IPersistable
    {
        // add additional members here
        //public int dataMember = 0; we cannot have fields in Interface
        //int privateData = 0;
        int DataMember { get; set; }
        new bool Save(object o)
        {
            return false;
        }
    }
    public class DataAccess : IDataAccessObject
    {
        int IDataAccessObject.DataMember { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPersistable.HasChanges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        object IPersistable.Read(string id)
        {
            throw new NotImplementedException();
        }

        bool IPersistable.Save(object o)
        {
            return true;
        }
    }
}
