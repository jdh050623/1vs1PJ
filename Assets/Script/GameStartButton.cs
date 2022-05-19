using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStartButton : MonoBehaviour
{
    void Update()
    {

    }
    public void StartButton()//시작 버튼을 클릭시 실행
    {
        SceneManager.LoadScene("Stage01");
    }
}
