using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Threading;

public class Stage01 : MonoBehaviour
{
    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ

    float number_of_Correctanimals = 0; // ���� ������ ��

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag== "ForestAnimals")// Ŭ���� ��ư�� �±װ� "ForestAnimals" �̸� ����
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);

            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal"; //Ŭ���� ��ư�� �±װ� "CorrectAnimal" ���� ����
            number_of_Correctanimals++; //���� ������ �� 1����
        }

        if(EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals") // Ŭ���� ��ư�� �±װ� "CorrectAnimal"�� "ForestAnimals"�� �ƴ϶�� ����
        {
            //wrong �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
            
            Debug.Log("dd");
        }
    }
}