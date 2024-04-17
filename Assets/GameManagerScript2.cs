using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript2 : MonoBehaviour
{
    //配列の宣言
    int[] map;
    void PrintArray()
    {
        //追加。文字列の宣言と初期化
        string debugText = "";

        for (int i = 0; i < map.Length; i++)
        {
            //変更。文字列に結合していく
            debugText += map[i].ToString() + ",";
        }

        Debug.Log(debugText);
    }
    int GetPlayerIndex() { 
    for(int i = 0; i = map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }

        }
        return -1;
    }
    //クラスの中メソッドの外に書くことに注意
    //返り値の型に注意
    bool MoveNumber(int number,int moveFrom,int moveTo)
    {
        //移動先が範囲外なら移動不可

        if (moveTo < 0 || maveTo >= map.Length)
        {
            //動けない条件を先に書きリターンする＝早期リターン
            return false;
        }
        //移動先に2(箱)が居たら
        if (map[moveTo] == 2)
        {
            //どの方向へ移動するかを算出
            int velocity = moveTo - moveFrom;

            //プライヤーの移動先からさらに先へ2(箱)を移動させる
            //
        }
     



            map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
    }
    // Start is called before the first frame update
    void Start()
    {
        //配列の実態の作成と初期化
        map = new int[] { 0, 0, 0, 1, 0, 2, 0, 0, 0 };
        PrintArray();


    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.RightArrow))
        {
            //メソッド化した処理を使用

            int playerIndex = GetPlayerIndex();
            //移動処理を関数化
            MoveNumber(1, playerIndex, playerIndex + 1);


            PrintArray();

        }
}
