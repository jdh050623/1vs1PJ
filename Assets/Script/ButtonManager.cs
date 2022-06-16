using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour //버튼 관련 스크립트
{
    public GameObject Out;
    public void BT01_1()
    {
        SceneManager.LoadScene("Stage01_2");
    }
    public void BT01_2()
    {
        SceneManager.LoadScene("Stage01_3");
    }
    public void BT02_1()
    {
        SceneManager.LoadScene("Stage02_2");
    }
    public void BT02_2()
    {
        SceneManager.LoadScene("Stage02_3");
    }
    public void BT03_1()
    {
        SceneManager.LoadScene("Stage03_2");
    }
    public void BT03_2()
    {
        SceneManager.LoadScene("Stage03_3");
    }
    public void BT04_1()
    {
        SceneManager.LoadScene("Stage04_2");
    }
    public void BT04_2()
    {
        SceneManager.LoadScene("Stage04_3");
    }
    public void BT05_1()
    {
        SceneManager.LoadScene("Stage05_2");
    }
    public void BT05_2()
    {
        SceneManager.LoadScene("Stage05_3");
    }
    public void BT06_1()
    {
        SceneManager.LoadScene("Stage06_2");
    }
    public void BT06_2()
    {
        SceneManager.LoadScene("Stage06_3");
    }
    public void BT01_3()
    {
        SceneManager.LoadScene("Stage02_1");
    }
    public void BT02_3()
    {
        SceneManager.LoadScene("Stage03_1");
    }
    public void BT03_3()
    {
        SceneManager.LoadScene("Stage04_1");
    }
    public void BT04_3()
    {
        SceneManager.LoadScene("Stage05_1");
    }
    public void BT05_3()
    {
        SceneManager.LoadScene("Stage06_1");
    }


    public void OutBT()
    {
        Out.SetActive(true);
    }
    public void NoOutBT()
    {
        Out.SetActive(false);
    }
    public void YesOutBT()
    {
        SceneManager.LoadScene("StageSelect");
        GameManager_1.instance.ClearCount = 0;
    }
}
