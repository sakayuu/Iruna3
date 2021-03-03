using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Item
{
    [CreateAssetMenu(fileName = "RecoveryItem", menuName = "CreateRecoveryItem")]
    class RecoveryItem : BaseItem
    {
        [SerializeField]
        private int hpHealPoint = 1;
        [SerializeField]
        private int mpHealPoint = 1;

        public void UseItem(ref int hp,ref int mp)
        {
            if (hpHealPoint == 0)
            {
                mp += mpHealPoint;
                return;
            }
            if(mpHealPoint == 0)
            {
                hp += hpHealPoint;
                return;
            }
            hp += hpHealPoint;
            mp += mpHealPoint;
        }
    }
}
