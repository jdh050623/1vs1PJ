using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Select_ : MonoBehaviour // ��ŸƮ�� �������� ����â ��ư�� ���õ� ��ũ��Ʈ�̴�.
{
    [Header("�������� ���� ����")]
    public GameObject ForestBG;
    public GameObject MountainBG;
    public GameObject BeachBG;
    public GameObject NorthPoleBG;
    public GameObject DesertBG;
    public GameObject AntarcticaBG;

    [Header("�ΰ��ӿ��� �ڷ� ������ ������� �ϴ� ��")]
    public GameObject StartBG;
    private void Update()
    {
        if (StartAni.instance.StartBTClick == true)
        {
            StartBG.SetActive(false);
        }
    }

    //�������� �׸� ����
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

    //�������� �׸� ������
    public void SelOut()
    {
        ForestBG.SetActive(false);
        MountainBG.SetActive(false);
        BeachBG.SetActive(false);
        NorthPoleBG.SetActive(false);
        DesertBG.SetActive(false);
        AntarcticaBG.SetActive(false);
    }

    //�������� �̵�
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
    //�������� n-0
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
    //�������� n-1

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
    //�������� n-2

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
