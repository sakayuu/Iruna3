using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    [CreateAssetMenu(fileName = "WeaponItem", menuName = "ScriptableObjects/Items/EquipmentItem/CreateWeapon")]
    class Weapon : EquipmentItem
    {
        public Weapon() : base()
        {

        }
    }
}
