using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStartButton : MonoBehaviour
{
    void Update()
    {

    }
    public void StartButton()//���� ��ư�� Ŭ���� ����
    {
        SceneManager.LoadScene("Stage01");
    }
}
