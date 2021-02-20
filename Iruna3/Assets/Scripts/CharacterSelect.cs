using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CharacterSelect : MonoBehaviour
{
    public List<string[]> playerData = new List<string[]>();

    void Start()
    {
        TextAsset data = Resources.Load("CSV/PlayerData") as TextAsset;
        StringReader reader = new StringReader(data.text);
        while(reader.Peek()>-1)
        {
            string line = reader.ReadLine();
            playerData.Add(line.Split(','));
        }
        for (int i = 0; i < playerData.Count; i++)
        {
            Debug.Log(playerData[i][0]+ playerData[i][1]+ playerData[i][2]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
