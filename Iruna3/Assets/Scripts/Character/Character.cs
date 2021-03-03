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

public class Character
{
    protected string name;

    protected Vector3 pos;

    protected GameObject model;

    public virtual Vector3 GetPos() => pos;

    public virtual void ModelLoad(out GameObject model, in string modelFolderName, in string modelName)
    {
        GameObject modelData = null;
        modelData = (GameObject)Resources.Load(modelFolderName + "/" + modelName);
        model = GameObject.Instantiate(modelData, Vector3.zero, Quaternion.identity);
    }
}
