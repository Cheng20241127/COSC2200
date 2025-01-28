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
        //public int dataMember = 0;
        int DataMember { get; set; }
    }
}
