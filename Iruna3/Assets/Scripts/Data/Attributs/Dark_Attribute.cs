using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Dark_Attribute : Clear_Attribute
    {
        public Dark_Attribute()
        {
            Name = "闇属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == typeof(Light_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
