using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data.Status
{
    /// <summary>
    /// プレイヤーのレベルを管理
    /// </summary>
    class PlayerLevelManager
    {
        /// <summary>
        /// レベルが上がっているかを監視（戦闘後に呼ぶ）
        /// </summary>
        /// <param name="experience">現在の経験値</param>
        /// <param name="nextExperience">次のレベルアップに必要な経験値</param>
        /// <param name="level">現在のレベル</param>
        public void LevelCheck(in float experience, ref float nextExperience, ref uint level)
        {
            if (experience < nextExperience)
                return;
            LevelUp(ref level);
            SetNextExperience(level, ref nextExperience);
        }

        /// <summary>
        /// プレイヤーのレベルを上げる
        /// </summary>
        /// <param name="level">現在のレベル</param>
        public void LevelUp(ref uint level)
            => level++;

        /// <summary>
        /// 次のレベルアップに必要な経験値を更新（レベル上げのマゾ度を調整↓ここ）
        /// </summary>
        /// <param name="level">現在のレベル</param>
        /// <param name="nextExperience">次のレベルアップに必要な経験値</param>
        public void SetNextExperience(in uint level, ref float nextExperience)
            => nextExperience = Mathf.RoundToInt(nextExperience * 1.5f + level * 3) / 2;

    }
}
