using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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

    public void OutBT()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
