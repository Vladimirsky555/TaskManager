using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Storage
{
    //Интерфейс сохранения данных
    interface IStorage
    {
        bool Save(Object element);
        Object Load(Type element);
    }
}
