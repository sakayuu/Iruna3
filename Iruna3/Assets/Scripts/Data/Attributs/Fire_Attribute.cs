using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class Fire_Attribute : Clear_Attribute
    {
        public Fire_Attribute()
        {
            Name = "火属性";
        }

        public override float Attack<T>(T attribute)
        {
            if (attribute.GetType() == GetType())
                return -0.2f;
            if (attribute.GetType() == typeof(Earth_Attribute))
                return 0.2f;
            return base.Attack(attribute);
        }
    }
}
