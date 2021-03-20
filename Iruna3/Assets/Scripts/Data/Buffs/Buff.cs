using Assets.Scripts.Utility.Timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Data.Buffs
{
    abstract class Buff : ScriptableObject
    {
        [SerializeField]
        private float timeLimit;
        private CountDownTimer countDownTimer;
        [SerializeField]
        private float toStartDisplay = 60;
        private bool isDisplayFlag = false;
        [SerializeField]
        private Image image = null;

        public bool IsDisplayFlag { get => isDisplayFlag; set => BuffIndicator(value); }

        public Buff()
        {
            countDownTimer = new CountDownTimer(timeLimit);
            countDownTimer.Initialize();
            image.transform.gameObject.SetActive(false);
        }

        public void Update()
        {
            countDownTimer.Update();
            TimeRemainCheck();

        }

        private void TimeRemainCheck()
        {
            if (isDisplayFlag)
                return;
            if (countDownTimer.TimeCount > toStartDisplay)
                return;
            IsDisplayFlag = true;
        }

        private void BuffIndicator(in bool value)
        {
            if (isDisplayFlag == value)
                return;
            isDisplayFlag = value;
            if (isDisplayFlag)
                image.transform.gameObject.SetActive(true);
        }
    }
}
