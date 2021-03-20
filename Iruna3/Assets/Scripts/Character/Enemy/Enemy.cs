using Assets.Scripts.Data.Status;
using Assets.Scripts.Data.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Character.Enemy
{
    class Enemy : Character
    {
        private EnemyStatus status;

        public GameObject Model { get => Model; set => Model = value; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        Enemy()
        {
            status = Resources.Load<EnemyStatus>("TestEnemy");

            Model = status.Model;

            Create();

        }

        protected override void AppendCreate()
        {
            base.AppendCreate();
            // ↓以下追加したい処理


        }

        protected override void AppendInitialize()
        {
            base.AppendInitialize();
        }

        protected override void AppendUpdate()
        {
            base.AppendUpdate();
        }

        //public void Attack()
        //{

        //}


    }
}