using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject Out;
    public void NextBT01()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void NextBT02()
    {
        SceneManager.LoadScene("Stage03");
    }

    public void NextBT03()
    {
        SceneManager.LoadScene("Stage04");
    }

    public void NextBT04()
    {
        SceneManager.LoadScene("Stage05");
    }

    public void NextBT05()
    {
        SceneManager.LoadScene("Stage06");
    }

    public void NextBT01_1()
    {
        SceneManager.LoadScene("Stage02_1");
    }

    public void NextBT02_1()
    {
        SceneManager.LoadScene("Stage03_1");
    }

    public void NextBT03_1()
    {
        SceneManager.LoadScene("Stage04_1");
    }

    public void NextBT04_1()
    {
        SceneManager.LoadScene("Stage05_1");
    }

    public void NextBT05_1()
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
