using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Status
{
    [CreateAssetMenu(fileName = "PlayerStatus", menuName = "ScriptableObjects/Status/CreatePlayerStatus")]
    class PlayerStatus : ScriptableObject
    {
        [SerializeField] //キャラの名前
        private string characterName;
        
        private float experience = 0;
        private float nextExperience = 0;

        private int level = 1; //レベル


        private int maxHp = 38;
        private int nowHp = 38;
        private int maxMp = 20;
        private int nowMp = 20;

        [SerializeField]
        private uint STR = 1;
        [SerializeField]
        private uint INT = 1;
        [SerializeField]
        private uint VIT = 1;
        [SerializeField]
        private uint AGI = 1;
        [SerializeField]
        private uint DEX = 1;
        [SerializeField]
        private uint CRT = 1;


        float atk = 12;
        float matk = 1;
        float def = 4;
        float mdef = 3;
        float hit = 2;
        float avd = 2;
        float aspd = 80;
        float sspd = 99;

        public PlayerStatus()
        {
            
        }

        
    }
}