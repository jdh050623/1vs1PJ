using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//����Ƽ ������ �̺�Ʈ �ý����� �ҷ���

public class Stage01 : MonoBehaviour
{
    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject Wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ

    float number_of_Correctanimals = 0; // ���� ������ ��

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals")// Ŭ���� ��ư�� �±װ� "ForestAnimals" �̸� ����
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);

            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal"; //Ŭ���� ��ư�� �±װ� "CorrectAnimal" ���� ����
            number_of_Correctanimals++; //���� ������ �� 1����
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals") // Ŭ���� ��ư�� �±װ� "CorrectAnimal"�� "ForestAnimals"�� �ƴ϶�� ����
        {
            //wrong �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
        }
    }
}