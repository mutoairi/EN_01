using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManajerScript : MonoBehaviour
{

    //�z��̐錾
    int[] map;
    // Start is called before the first frame update
    void Start()
    {
        //�z��̎��Ԃ̍쐬�Ə�����
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        for(int i = 0; i < map.Length; i++)
        {
            //�v�f��������o��
            Debug.Log(map[i] + ",");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
