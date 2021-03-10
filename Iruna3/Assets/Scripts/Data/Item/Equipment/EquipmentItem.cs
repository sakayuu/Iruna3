using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    abstract class EquipmentItem : BaseItem
    {
        public EquipmentItem()
        {
            itemType = ItemType.Equipment;
        }
    }
}
