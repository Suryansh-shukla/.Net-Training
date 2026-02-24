namespace MVC_Core_Web_App.Models
{
    public interface IRepo<T>
    {
        bool AddData(T obj);
        bool UpdateData(int id,T obj);
        bool DeleteData(int id);
        List<T> ShowAllData();
        T ShowDetailsByID(int id);
    }
}
