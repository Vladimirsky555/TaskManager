using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class ModelBase
    {
        [Model(IsVisible = false)]
        public Guid ID { get; set; }

        [Model(IsVisible = true, IsEditable = false, Label = "Дата создания")]
        public DateTime CreateDate { get; set; }

        [Model(IsVisible = true, IsEditable = false, Label = "Дата изменения")]
        public DateTime UpdateDate { get; set; }

        [Model(IsVisible = false)]
        public bool IsDeleted { get; set; }

        [Model(IsVisible = false)]
        public Guid UserGuid { get; set; }

        public UserModel GetUser()
        {
            //TODO Добавить вывод пользователя по полю UserGuid
            return null;
        }

        public ModelBase()
        {
            ID = Guid.NewGuid();
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
