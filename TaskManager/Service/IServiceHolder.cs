using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Service
{
    //Сервис хранения зависимостей
    interface IServiceHolder
    {
        //Регистрация сервиса в качестве зависимости
        bool RegisterService(Type description, Object service);
        //Снятие регистрации сервиса
        bool UnRegisterService(Type service);
        //Получение сервиса
        Object GetService(Type service);
        //Очистить все
        bool ClearAll();
        //Построить объект со всеми зависимостями
        Object CreateObject(Type description);
    }
}
