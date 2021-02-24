using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
enum Attribute
{
    fire,
    water,
    wind,
    earth,
    dark,
    light
}

/// <summary>
/// 攻撃性
/// </summary>
enum Aggression
{
    passive,
    underActive,
    active
}

class Enemy : Character
{

    /// <summary>
    /// コンストラクタ
    /// </summary>
    Enemy(
        string name,
        int level,
        string[] dropItem,
        bool[] specialAttack,
        Attribute attribute,
        int exp,
        int hp,
        int def,
        Aggression aggression)
    {
        this.name = name;
    }

    public void Attack()
    {

    }


}

