using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Light_Attribute : Clear_Attribute
    {
        public Light_Attribute()
        {
            Name = "光属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == typeof(Dark_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
