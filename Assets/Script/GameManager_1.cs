using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_1 : MonoBehaviour
{
    public static GameManager_1 instance = null;
    public GameObject GameClear;

    public int ClearCount = 0;//몇번 답을 맞췄는지에 세준다
    private void Start()
    {
            instance = this; //내자신을 instance로 넣어줍니다.
    }
    private void Update()
    {
        if(ClearCount == 2)
        {
            GameClear.SetActive(true);
        }
    }
}
