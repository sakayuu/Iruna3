using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Utility.Timer
{
    class CountDownTimer : Timer
    {
        private float timeLimit = 0;
        private bool isTimeLimit = false;

        public CountDownTimer(float timeLimit = 1)
        {
            this.timeLimit = timeLimit;
            Initialize();
        }

        public float TimeLimit { get => timeLimit; set => timeLimit = value; }

        protected override void AppendInitialize()
        {
            TimeReset();
            isTimeLimit = false;
        }

        private void TimeReset()
        {
            timeCount = timeLimit;
        }

        protected override void AppendUpdate()
        {
            CountDown(ref timeCount);
        }

        private void CountDown(ref float timeCount)
        {
            if (isTimeLimit)
                return;
            if (timeCount > 0)
            {
                timeCount -= Time.deltaTime;
                return;
            }
            timeCount = 0;
            isTimeLimit = true;
        }
    }
}
