using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_1 : MonoBehaviour
{
    public static GameManager_1 instance = null;
    public GameObject GameClear;

    public int ClearCount = 0;//��� ���� ��������� ���ش�
    private void Start()
    {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
    }
    private void Update()
    {
        if(ClearCount == 2)
        {
            GameClear.SetActive(true);
        }
    }
}
