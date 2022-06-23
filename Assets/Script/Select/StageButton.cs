using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageButton : MonoBehaviour // 스타트와 스테이지 선택창 버튼에 관련된 스크립트이다.
{
    [Header("스테이지 선택 구역")]
    public GameObject ForestBG;
    public GameObject MountainBG;
    public GameObject BeachBG;
    public GameObject NorthPoleBG;
    public GameObject DesertBG;
    public GameObject AntarcticaBG;

    //스테이지 테마 선택
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

    //스테이지 이동
    public void Stage01_0()
    {
        SceneManager.LoadScene("Stage01_0");
    }
    public void Stage02_0()
    {
        SceneManager.LoadScene("Stage02_0");
    }
    public void Stage03_0()
    {
        SceneManager.LoadScene("Stage03_0");
    }
    public void Stage04_0()
    {
        SceneManager.LoadScene("Stage04_0");
    }
    public void Stage05_0()
    {
        SceneManager.LoadScene("Stage05_0");
    }
    public void Stage06_0()
    {
        SceneManager.LoadScene("Stage06_0");
    }
    //스테이지 n-0
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
    //스테이지 n-1

    public void Stage01_2()
    {
        SceneManager.LoadScene("Stage01_2");
    }
    public void Stage02_2()
    {
        SceneManager.LoadScene("Stage02_2");
    }
    public void Stage03_2()
    {
        SceneManager.LoadScene("Stage03_2");
    }
    public void Stage04_2()
    {
        SceneManager.LoadScene("Stage04_2");
    }
    public void Stage05_2()
    {
        SceneManager.LoadScene("Stage05_2");
    }
    public void Stage06_2()
    {
        SceneManager.LoadScene("Stage06_2");
    }
    //스테이지 n-2

    public void Stage01_3()
    {
        SceneManager.LoadScene("Stage01_3");
    }
    public void Stage02_3()
    {
        SceneManager.LoadScene("Stage02_3");
    }
    public void Stage03_3()
    {
        SceneManager.LoadScene("Stage03_3");
    }
    public void Stage04_3()
    {
        SceneManager.LoadScene("Stage04_3");
    }
    public void Stage05_3()
    {
        SceneManager.LoadScene("Stage05_3");
    }
    public void Stage06_3()
    {
        SceneManager.LoadScene("Stage06_3");
    }
}
