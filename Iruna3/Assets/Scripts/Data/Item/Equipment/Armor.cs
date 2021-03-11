using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    [CreateAssetMenu(fileName = "ArmorItem", menuName = "ScriptableObjects/Items/EquipmentItem/CreateArmor")]
    class Armor : EquipmentItem
    {
        public Armor() : base()
        {

        }
    }
}
