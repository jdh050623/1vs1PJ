using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NextBT()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void OutBT()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
