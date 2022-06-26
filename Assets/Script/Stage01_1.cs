using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage01_1 : MonoBehaviour
{
    public GameObject GameClear;
    void Update()
    {
        if (GameManager_1.instance.ClearCount == 2)
        {
            GameClear.SetActive(true);
        }
    }
}
