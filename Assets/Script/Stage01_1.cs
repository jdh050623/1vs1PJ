using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage01_1 : MonoBehaviour
{
    public int ClearCount = 0;//��� ���� ��������� ���ش�
    void Update()
    {
        if(ClearCount == 2)
        {
            SceneManager.LoadScene("StageSelect");
        }
    }
}
