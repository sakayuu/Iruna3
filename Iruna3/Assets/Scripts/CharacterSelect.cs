using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public List<string[]> playerData = new List<string[]>();
    public GameObject[] player = new GameObject[3];
    public Text Level, CharaName;
    public int select = 0;
    [SerializeField]
    public GameObject right;
    [SerializeField]
    public GameObject left;
    public GameObject camera;

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

        for(int i=0;i<playerData.Count;i++)
        {
            player[i]= (GameObject)Resources.Load("Character/"+playerData[i][0]);
            player[i]=UnityEngine.Object.Instantiate(player[i], new Vector3(i*5,0,0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (left.GetComponent<button>().ClickFlag)
        {
            if (select <= 0)
                return;
            select--;
            left.GetComponent<button>().ButtonReset();
        }
        if (right.GetComponent<button>().ClickFlag)
        {
            if (select >= 1)
                return;
            select++;
            right.GetComponent<button>().ButtonReset();
        }
       
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            select = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            select = 1;
        }
        Level.text = "Lv" + playerData[select][1];//レベルテキストに書き出し
        CharaName.text = playerData[select][0];//キャラネームテキストに書き出し
        camera.gameObject.transform.position = new Vector3(5 * select, 1, -10);//selectによってカメラの位置を変える
    }
}
