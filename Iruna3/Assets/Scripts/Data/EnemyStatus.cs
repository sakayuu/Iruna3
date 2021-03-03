using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Data.Item;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(fileName ="EnemyStatus",menuName ="CreateEnemyStatus")]
    class EnemyStatus : ScriptableObject
    {
        /// <summary>
        /// 攻撃性
        /// </summary>
        public enum Aggression
        {
            passive,
            underActive,
            active
        }

        [SerializeField] //キャラの名前
        private new string name;
        [SerializeField] //レベル
        private int level;
        [SerializeField] //死亡時に落とすアイテム
        private BaseItem[] dropItems = new BaseItem[4];
        [SerializeField] //特殊攻撃があるかどうか
        private bool[] specialAttack;
        [SerializeField] //属性
        private Attribute attribute;
        [SerializeField] //倒したときに入手できる経験値
        private int exp;
        [SerializeField] //体力
        private int hp;
        [SerializeField] //防御力
        private int def;
        [SerializeField] //攻撃性
        private Aggression aggression;
    };
}
