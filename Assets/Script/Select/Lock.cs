using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour //  자물쇠 스크립트
{   [Header("스테이지 테마 락")]
    public GameObject[] StageLock1;//스테이지 테마의 Lock

    [Header("스테이지 락")]
    public GameObject[] Lock1;//스테이지 창의 Lock

    // Update is called once per frame
    void Update()
    {

        Lock1[LockOnOff.instance.GameCle].SetActive(false);
        if(LockOnOff.instance.GameCle == 4)
        {
            StageLock1[0].SetActive(false);
        }

        if (LockOnOff.instance.GameCle == 8)
        {
            StageLock1[1].SetActive(false);
        }

        if (LockOnOff.instance.GameCle == 12)
        {
            StageLock1[2].SetActive(false);
        }

        if (LockOnOff.instance.GameCle == 16)
        {
            StageLock1[3].SetActive(false);
        }

        if (LockOnOff.instance.GameCle == 20)
        {
            StageLock1[4].SetActive(false);
        }


    }
}
