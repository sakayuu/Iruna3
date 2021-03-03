using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public List<string[]> saveData1 = new List<string[]>();
    public List<string[]> saveData2 = new List<string[]>();
    public List<string[]> saveData3 = new List<string[]>();

    public List<List<string[]>> playerList = new List<List<string[]>>();
    //public List<string> playerList = new List<string>();

    public GameObject[] player = new GameObject[3];
    public Text Level, CharaName;
    public int select = 0;
    [SerializeField]
    public GameObject right;
    [SerializeField]
    public GameObject left;
    [SerializeField]
    public GameObject start;
    public GameObject camera;

    void Start()
    {
        //TextAsset data = Resources.Load("CSV/PlayerData") as TextAsset;
        //StringReader reader = new StringReader(data.text);
        //while(reader.Peek()>-1)
        //{
        //    string line = reader.ReadLine();
        //    playerData.Add(line.Split(','));
        //}

        CSVRead("SaveData1",ref saveData1);
        CSVRead("SaveData2",ref saveData2);
        CSVRead("SaveData3",ref saveData3);

        //for (int i = 0; i < playerData1.Count; i++)
        //{
        //    Debug.Log(playerData1[i][0]+ playerData1[i][1]+ playerData1[i][2]);
        //}
        for (int i = 0; i < playerList.Count; i++)
        {
            List<string[]> name = playerList[i];
            player[i] = (GameObject)Resources.Load("Character/" + playerList[i][0][0].ToString());
            player[i] = UnityEngine.Object.Instantiate(player[i], new Vector3(i * 5, 0, 0), Quaternion.identity);
        }

        //for (int i = 0; i < playerData1.Count; i++)
        //{
        //    player[i] = (GameObject)Resources.Load("Character/" + playerData1[i][0]);
        //    player[i] = UnityEngine.Object.Instantiate(player[i], new Vector3(i * 5, 0, 0), Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (left.GetComponent<button>().ClickFlag)//左のボタンを押した時
        {
            if (select <= 0)
                return;
            select--;
            left.GetComponent<button>().ButtonReset();
        }
        if (right.GetComponent<button>().ClickFlag)//右のボタンを押した時
        {
            if (select >= 1)
                return;
            select++;
            right.GetComponent<button>().ButtonReset();
        }
        if(start.GetComponent<button>().ClickFlag)//スタートボタンを押したとき
        {
            SceneManager.sceneLoaded += GameScenepaded;

            SceneManager.LoadScene("GameScene");
        }
       
        Level.text = "Lv" + playerList[select][0][1];//レベルテキストに書き出し
        CharaName.text = playerList[select][0][0];//キャラネームテキストに書き出し
        camera.gameObject.transform.position = new Vector3(5 * select, 1, -10);//selectによってカメラの位置を変える
    }
    void CSVRead(string dataname,ref List<string[]> list)//テキストの名前、保存するリスト　　　CSV読み込み用
    {
        TextAsset data = Resources.Load("CSV/"+ dataname) as TextAsset;
        if (data == null)
            return;
        StringReader reader = new StringReader(data.text);
        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            list.Add(line.Split(','));
        }
        playerList.Add(list);
    }
    void GameScenepaded(Scene next,LoadSceneMode mode)
    {
        //シーン切り替え後のスクリプトを取得
        var gamePlayManager = GameObject.FindWithTag("GamePlayManager").GetComponent<GamePlayManager>();

        //ここでデータを渡す

        //イベントから削除
        SceneManager.sceneLoaded -= GameScenepaded;
    }
}
