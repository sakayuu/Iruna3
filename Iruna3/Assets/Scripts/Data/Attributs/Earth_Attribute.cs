using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Earth_Attribute : Clear_Attribute
    {
        public Earth_Attribute()
        {
            Name = "地属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == GetType())
                return -0.2f;
            if (attribute.GetType() == typeof(Wind_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
