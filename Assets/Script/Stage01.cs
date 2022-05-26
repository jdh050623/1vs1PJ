using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stage01 : MonoBehaviour
{
    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject Wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ
    public GameObject Clear;

    float number_of_Correctanimals = 0; // ���� ������ ��

    private void Update()
    {
        if(number_of_Correctanimals == 2)
        {
            Clear.SetActive(true);
        }
    }

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals")
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //���� ������ �� 1����
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals")
        {
            //wrong �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
                
            Debug.Log("d");
        }

    }
    IEnumerator Corutin()
    {
        yield return new WaitForSeconds(3);
    }
}