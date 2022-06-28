using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stage01 : MonoBehaviour
{
    IEnumerator coru;

    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject Wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ
    public GameObject Clear; //Ŭ���� ������ ������ â

    public GameObject Ani1;
    public GameObject Ani2;

    private bool ClearTrue = false; //Ŭ���� ������ Ŭ���� â�� ��� ���� �ʰ� ���ִ� ��
    private bool Click = false;//Ʋ������ Ŭ���� ��Ÿ�� ����

    float number_of_Correctanimals = 0; // ���� ������ ��

    private void Update()
    {
        if (number_of_Correctanimals == 2 && ClearTrue == false)
        {
            AniTime();
            Clear.SetActive(true);
            ClearTrue = true;
        }
    }

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals" && Click == false)
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            
            Instantiate(Ani1, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //���� ������ �� 1����

            Destroy(EventSystem.current.currentSelectedGameObject);
        }

        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals2" && Click == false)
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Ani2, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //���� ������ �� 1����
            Destroy(EventSystem.current.currentSelectedGameObject);
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals2" && Click == false)
        {
            Click = true;
            //wrong �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Corutin();
            Click = false;
        }
    }
    IEnumerator Corutin()
    {
        yield return new WaitForSeconds(1);
    }

    IEnumerator AniTime()
    {
        yield return new WaitForSeconds(3);
        
    }
}