using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class ModelBase
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }

        public ModelBase()
        {
            ID = Guid.NewGuid();
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
