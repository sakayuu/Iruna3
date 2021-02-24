using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Data;

public class Character
{
    Status status;

    protected string name;

    protected Vector3 pos;

    public virtual Vector3 GetPos() => pos;
   

}
