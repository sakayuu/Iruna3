using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Wind_Attribute : Clear_Attribute
    {
        public Wind_Attribute()
        {
            Name = "風属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == GetType())
                return -0.2f;
            if (attribute.GetType() == typeof(Water_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
