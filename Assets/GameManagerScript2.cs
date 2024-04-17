using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript2 : MonoBehaviour
{
    //�z��̐錾
    int[] map;
    void PrintArray()
    {
        //�ǉ��B������̐錾�Ə�����
        string debugText = "";

        for (int i = 0; i < map.Length; i++)
        {
            //�ύX�B������Ɍ������Ă���
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
    //�N���X�̒����\�b�h�̊O�ɏ������Ƃɒ���
    //�Ԃ�l�̌^�ɒ���
    bool MoveNumber(int number,int moveFrom,int moveTo)
    {
        //�ړ��悪�͈͊O�Ȃ�ړ��s��

        if (moveTo < 0 || maveTo >= map.Length)
        {
            //�����Ȃ��������ɏ������^�[�����遁�������^�[��
            return false;
        }
        //�ړ����2(��)��������
        if (map[moveTo] == 2)
        {
            //�ǂ̕����ֈړ����邩���Z�o
            int velocity = moveTo - moveFrom;

            //�v���C���[�̈ړ��悩�炳��ɐ��2(��)���ړ�������
            //
        }
     



            map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
    }
    // Start is called before the first frame update
    void Start()
    {
        //�z��̎��Ԃ̍쐬�Ə�����
        map = new int[] { 0, 0, 0, 1, 0, 2, 0, 0, 0 };
        PrintArray();


    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.RightArrow))
        {
            //���\�b�h�������������g�p

            int playerIndex = GetPlayerIndex();
            //�ړ��������֐���
            MoveNumber(1, playerIndex, playerIndex + 1);


            PrintArray();

        }
}
