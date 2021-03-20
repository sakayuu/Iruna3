using Assets.Scripts.Data.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Data.Status
{
    class PlayerStatusManagement
    {
        public string CheckWeapon<_Weapon>(in _Weapon weapon)
            where _Weapon: Weapon
        {
            if (weapon.GetType() == typeof(Weapon))
                return "武器";

            return "イエーイ";
        }


        public void ATKCheck(in Dictionary<string,uint> status,in Weapon weapon)
        {
            var weaponType = CheckWeapon(weapon);

            if(weaponType == "剣")
            {
                var atk = status["str"] * 3 + status["dex"] * 1;
            }
        }

    }
}
