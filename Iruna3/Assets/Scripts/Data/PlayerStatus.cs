using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(fileName = "PlayerStatus", menuName = "ScriptableObjects/Status/CreatePlayerStatus")]
    class PlayerStatus : ScriptableObject
    {
        [SerializeField]
        private int STR = 1;
        [SerializeField]
        private int INT = 1;
        [SerializeField]
        private int VIT = 1;
        [SerializeField]
        private int AGI = 1;
        [SerializeField]
        private int DEX = 1;
        [SerializeField]
        private int CRT = 1;

        [SerializeField]
        int level;
        [SerializeField]
        int hp;
        [SerializeField]
        int mp;
        [SerializeField]
        int atk;
        [SerializeField]
        int matk;
        [SerializeField]
        int def;
        [SerializeField]
        int mdef;
        [SerializeField]
        int hit;
        [SerializeField]
        int avd;
        int aspd;
        int sspd;

        


    }
}