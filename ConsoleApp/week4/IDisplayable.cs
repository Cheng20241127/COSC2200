namespace ConsoleApp.week4
{
    public interface IDisplayable { string GetDisplayText(string sep) => ToString() + sep; }
    public interface IPersistable
    {
        object Read(string id);
        bool Save(string id);
        bool HasChanges { get; set; }
    }
    public interface IDataAccessObject : IDisplayable, IPersistable
    {
        // add additional members here
        //public int dataMember = 0; we cannot have fields in Interface
        //int privateData = 0;
        int DataMember { get; set; }
        bool Save2(string id)
        {
            return false;
        }
    }
    public class DataAccess : IDataAccessObject
    {
        int IDataAccessObject.DataMember { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPersistable.HasChanges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object IPersistable.Read(string id)
        {
            return null;
        }
        public bool IPersistable.Save(string id)
        {
            return false;
        }
        //bool IDataAccessObject.Save2(object o) {
        //    return IDataAccessObject.Save2(o);
        //}
    }
    public class DataAccessObject : IDisplayable, IPersistable
    {
        bool IPersistable.HasChanges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        object IPersistable.Read(string id)
        {
            return null;
        }

        bool IPersistable.Save(string id)
        {
            return false;
        }
    }

}
