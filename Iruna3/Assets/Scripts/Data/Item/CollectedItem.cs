using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    [CreateAssetMenu(fileName = "CollectedItem", menuName = "ScriptableObjects/Items/CreateCollectedItem")]
    class CollectedItem : BaseItem
    {
        public CollectedItem()
        {
            itemType = ItemType.Collected;
        }
    }
}
