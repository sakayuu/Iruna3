using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Water_Attribute : Clear_Attribute
    {
        public Water_Attribute()
        {
            Name = "水属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == GetType())
                return -0.2f;
            if (attribute.GetType() == typeof(Fire_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
