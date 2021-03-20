using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Utility.Timer
{
    abstract class Timer
    {
        protected float timeCount = 0;
        public float TimeCount { get => timeCount; set => timeCount = value; }

        public Timer()
        {

        }


        public void Initialize()
        {
            AppendInitialize();
        }

        protected abstract void AppendInitialize();

        public void Update()
        {
            AppendUpdate();
        }

        protected abstract void AppendUpdate();

    }
}
