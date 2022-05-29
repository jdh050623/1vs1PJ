using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stage03 : MonoBehaviour
{
    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject Wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ
    public GameObject Clear; //Ŭ���� ������ ������ â

    private bool ClearTrue = false; //Ŭ���� ������ Ŭ���� â�� ��� ���� �ʰ� ���ִ� ��
    private bool Click = false;//Ʋ������ Ŭ���� ��Ÿ�� ����

    float number_of_Correctanimals = 0; // ���� ������ ��

    private void Update()
    {
        if (number_of_Correctanimals == 2 && ClearTrue == false)
        {
            Clear.SetActive(true);
            ClearTrue = true;
        }
    }

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "BeachAnimals" && Click == false)
        {
            //Right �� Ŭ���� ��ư ��ġ�� ��ȯ
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //���� ������ �� 1����
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "BeachAnimals" && Click == false)
        {
            Click = true;
            //wrong �� Ŭ���� ��ư ��ġ�� ��ȯ
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Corutin();
            Click = false;
        }

    }
    IEnumerator Corutin()
    {
        yield return new WaitForSeconds(1);
    }
}
