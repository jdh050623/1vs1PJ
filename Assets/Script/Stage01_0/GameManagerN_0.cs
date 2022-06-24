using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerN_0 : MonoBehaviour //다른 스크립트에 필요한 것을 빌려주는 스크립트 
{
    public static GameManagerN_0 instance = null; //쓸때는 GameManagerN_0(클래스 이름).instance(지정한 이름).n_0Clear(쓸 함수,변수)
    public GameObject GameClear_0;

    public bool Second;

    public int Clear = 0;//클리어 했는지 확인해 준다.
    private void Awake()
    {
        Second = false;
        Clear = 0;
        instance = this; //내자신을 instance로 넣어줍니다.
    }
    private void Update()
    {
        if (Clear == 2)
        {
            GameClear_0.SetActive(true);
            Clear = 0;
        }
    }
}
