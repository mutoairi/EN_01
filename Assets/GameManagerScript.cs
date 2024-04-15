using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManajerScript : MonoBehaviour
{

    //配列の宣言
    int[] map;
    // Start is called before the first frame update
    void Start()
    {
        //配列の実態の作成と初期化
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        for(int i = 0; i < map.Length; i++)
        {
            //要素数を一つずつ出力
            Debug.Log(map[i] + ",");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
