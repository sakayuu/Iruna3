using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Data.Item;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(fileName = "EnemyStatus", menuName = "ScriptableObjects/Status/CreateEnemyStatus")]
    class EnemyStatus : ScriptableObject
    {
        /// <summary>
        /// 攻撃性
        /// </summary>
        private enum Aggression
        {
            passive,
            underActive,
            active
        }

        [SerializeField] //キャラの名前
        private string characterName;
        [SerializeField] //レベル
        private int level;
        [SerializeField] //死亡時に落とすアイテム
        private BaseItem[] dropItems = new BaseItem[4];
        [SerializeField] //特殊攻撃があるかどうか
        private bool[] specialAttack;
        [SerializeField] //属性
        private Attribute attributeParameter;
        [SerializeField] //倒したときに入手できる経験値
        private int exp;
        [SerializeField] //体力
        private int hp;
        [SerializeField] //防御力
        private int def;
        [SerializeField] //攻撃性
        private Aggression aggression;
        [SerializeField] //3Dモデル
        private GameObject model;

        public string CharacterName { get => characterName; }
        public int Level { get => level; }
        public BaseItem[] DropItems { get => dropItems; }
        public bool[] SpecialAttack { get => specialAttack; }
        public Attribute AttributeParameter { get => attributeParameter; set => attributeParameter = value; }
        public int Exp { get => exp; }
        public int Hp { get => hp; }
        public int Def { get => def; }
        public GameObject Model { get => model; }
    };
}
