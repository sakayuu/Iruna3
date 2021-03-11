using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public abstract class Character
    {
        private GameObject model = null;
        private bool deadFlag = false;

        public GameObject Model { get => model; set => model = value; }
        public bool DeadFlag { get => deadFlag; set => CheckDeadFlag(value); }

        #region 生成処理
        public void Create() => AppendCreate();

        protected virtual void AppendCreate() => RequiredCreate();

        private void RequiredCreate() => ModelLoad(ref model);
        #endregion

        #region 初期化処理
        public void Initialize() => AppendInitialize();

        protected virtual void AppendInitialize() => RequiredInitialize();

        private void RequiredInitialize() => DeadFlag = false;
        #endregion

        #region 更新処理
        public void Update() => AppendUpdate();

        protected virtual void AppendUpdate() => RequiredUpdate();

        private void RequiredUpdate()
        {

        }

        #endregion

        private void ModelLoad(ref GameObject model) => model = GameObject.Instantiate(model, Vector3.zero, Quaternion.identity);
        private void ModelUnload() => GameObject.Destroy(model);

        private void CheckDeadFlag(bool deadFlag)
        {
            if (this.deadFlag == deadFlag)
                return;
            this.deadFlag = deadFlag;
            if (this.deadFlag)
                ModelUnload();
        }

    }

}