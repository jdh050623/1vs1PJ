using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour //  �ڹ��� ��ũ��Ʈ
{   [Header("�������� �׸� ��")]
    public GameObject[] StageLock1;//�������� �׸��� Lock

    [Header("�������� ��")]
    public GameObject[] Lock1;//�������� â�� Lock

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
