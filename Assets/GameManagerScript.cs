using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //配列の宣言
    int[] map;


    // Start is called before the first frame update
    void Start()
    {
        //配列の実態の作成と初期化
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };


    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.RightArrow))
        {
            //playerIndex
            int playerIndex = -1;
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }
            /*
             playerIndex+1のインデックスのものと交換するので
            playerIndex-1よりさらに小さいインデックスの時のみ交換処理を行う
             */
            if (playerIndex < map.Lengh - 1)
            {
                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;
            }
            //追加。文字列の宣言と初期化
            string debugText = "";

            for (int i = 0; i < map.Length; i++)
            {
                //変更。文字列に結合していく
                debugText += map[i].ToString() + ",";
            }

            Debug.Log(debugText);

        };
    }
}

