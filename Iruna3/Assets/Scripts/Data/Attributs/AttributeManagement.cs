using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Attributs
{
    class AttributeManagement
    {
        /// <summary>
        /// 属性のダメージ計算
        /// </summary>
        /// <typeparam name="_Attribute">属性の型</typeparam>
        /// <param name="AttackDamage">元のダメージ</param>
        /// <param name="AttackAttribute">攻撃側の属性</param>
        /// <param name="DefenseAttribute">防御側の属性</param>
        /// <returns></returns>
        public float AttributeDamageCheck<_Attribute>(float AttackDamage, _Attribute AttackAttribute, _Attribute DefenseAttribute)
            where _Attribute : Clear_Attribute
        {
            return AttackDamage + AttackDamage * AttackAttribute.Attack(DefenseAttribute);
        }
    }
}
