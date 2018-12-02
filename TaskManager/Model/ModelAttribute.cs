using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    class ModelAttribute : Attribute
    {
        public string Label      { get; set; }
        public bool   IsVisible  { get; set; }
        public bool   IsEditable { get; set; }
    }
}
