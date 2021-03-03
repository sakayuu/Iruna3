using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    public abstract class BaseItem : ScriptableObject
    {
        protected enum ItemType
        {
            // 回復系
            Recovery,
            // 消費系
            Consumables,
            // 収集系
            Collected,
            // 装備系
            Equipment,
        }
        [SerializeField]
        protected ItemType itemType = ItemType.Collected;
        [SerializeField]
        protected uint id = 0;
        [SerializeField]
        protected new string name = "仮のアイテム";
        [SerializeField]
        protected string description = "仮だから説明は無いよ";
        [SerializeField]
        protected uint price = 1;

        protected virtual ItemType GetItemType => itemType;
        protected virtual uint GetId() => id;
        protected virtual string GetName => name;
        protected virtual string GetDescription => description;
        protected virtual uint GetPrice => price;
    }
}
