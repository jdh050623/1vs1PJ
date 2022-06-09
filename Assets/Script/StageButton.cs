using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageButton : MonoBehaviour // 스테이지 선택창 버튼에 관련된 스크립트이다.
{
    //테마별 스테이지 창 
    public GameObject ForestBG;
    public GameObject MountainBG;
    public GameObject BeachBG;
    public GameObject NorthPoleBG;
    public GameObject DesertBG;
    public GameObject AntarcticaBG;
    public void ForestBT()
    {
        ForestBG.SetActive(true);
    }
    public void MountainBT()
    {
        MountainBG.SetActive(true);
    }
    public void BeachBT()
    {
        BeachBG.SetActive(true);
    }
    public void NorthPoleBT()
    {
        NorthPoleBG.SetActive(true);
    }
    public void DesertBT()
    {
        DesertBG.SetActive(true);
    }
    public void AntarcticaBT()
    {
        AntarcticaBG.SetActive(true);
    }
    public void ForestOutBT()
    {
        ForestBG.SetActive(false);
    }
    public void MountainOutBT()
    {
        MountainBG.SetActive(false);
    }
    public void BeachOutBT()
    {
        BeachBG.SetActive(false);
    }
    public void NorthPoleOutBT()
    {
        NorthPoleBG.SetActive(false);
    }
    public void DesertOutBT()
    {
        DesertBG.SetActive(false);
    }
    public void AntarcticaOutBT()
    {
        AntarcticaBG.SetActive(false);
    }
    public void Stage01()
    {
        SceneManager.LoadScene("Stage01");
    }

    public void Stage02()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void Stage03()
    {
        SceneManager.LoadScene("Stage03");
    }

    public void Stage04()
    {
        SceneManager.LoadScene("Stage04");
    }

    public void Stage05()
    {
        SceneManager.LoadScene("Stage05");
    }

    public void Stage06()
    {
        SceneManager.LoadScene("Stage06");
    }

    public void Stage01_1()
    {
        SceneManager.LoadScene("Stage01_1");
    }

    public void Stage02_1()
    {
        SceneManager.LoadScene("Stage02_1");
    }

    public void Stage03_1()
    {
        SceneManager.LoadScene("Stage03_1");
    }

    public void Stage04_1()
    {
        SceneManager.LoadScene("Stage04_1");
    }

    public void Stage05_1()
    {
        SceneManager.LoadScene("Stage05_1");
    }

    public void Stage06_1()
    {
        SceneManager.LoadScene("Stage06_1");
    }
}
