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
        if (LockOnOff.instance.GameCle >= 1)
        {
            Lock1[1].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 2)
        {
            Lock1[2].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 3)
        {
            Lock1[3].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 4)
        {
            StageLock1[0].SetActive(false);
            Lock1[4].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 5)
        {
            Lock1[5].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 6)
        {
            Lock1[6].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 7)
        {
            Lock1[7].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 8)
        {
            StageLock1[1].SetActive(false);
            Lock1[8].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 9)
        {
            Lock1[9].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 10)
        {
            Lock1[10].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 11)
        {
            Lock1[11].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 12)
        {
            StageLock1[2].SetActive(false);
            Lock1[12].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 13)
        {
            Lock1[13].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 14)
        {
            Lock1[14].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 15)
        {
            Lock1[15].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 16)
        {
            StageLock1[3].SetActive(false);
            Lock1[16].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 17)
        {
            Lock1[17].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 18)
        {
            Lock1[18].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 19)
        {
            Lock1[19].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 20)
        {
            StageLock1[4].SetActive(false);
            Lock1[20].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 21)
        {
            Lock1[21].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 22)
        {
            Lock1[22].SetActive(false);
        }

        if (LockOnOff.instance.GameCle >= 23)
        {
            Lock1[23].SetActive(false);
        }

    }
}
