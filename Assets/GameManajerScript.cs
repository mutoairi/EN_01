using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    //�z��̐錾
    int[] map;
    // Start is called before the first frame update
    void Start()
    {
        //�z��̎��Ԃ̍쐬�Ə�����
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };

        //�ǉ��B������̐錾�Ə�����
        string debugText = "";

        for(int i = 0; i < map.Length; i++)
        {
            //�ύX�B������Ɍ������Ă���
            debugText += map[i].ToString() + ",";       }

        Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
