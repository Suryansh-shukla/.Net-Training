using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDisconnArchDemo
{
    public interface IRepo<T>
    {
        bool AddData(T data);
        bool UpdateData(int id,T data);
        bool DeleteData(int id);
        List<T> ShowAllData();
        T SeachById(int id);
    }
}
