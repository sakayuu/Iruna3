using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Clear_Attribute
    {
        private string name = "無属性";

        public string Name { get => name; protected set => name = value; }

        public Clear_Attribute()
        {
            name = "無属性";
        }

        public virtual float Attack<T>(T attribute)
            where T : Clear_Attribute => 0;
        
    }
}
