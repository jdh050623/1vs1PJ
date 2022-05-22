using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Stage01 : MonoBehaviour // ��������1�� �ý���
{
    public GameObject Right; //Ŭ���� ������ ���������� �´� �����϶� ������ ������Ʈ
    public GameObject Wrong; //Ŭ���� ������ ���������� Ʋ�� �����϶� ������ ������Ʈ

    float number_of_Correctanimals = 0; // ���� ������ ��

    void Update()
    {
        if(number_of_Correctanimals == 2)
        {
            SceneManager.LoadScene("Stage02");
        }
    }

    public void AnimalClick()//������ Ŭ��������
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals")// Ŭ���� ��ư�� �±װ� "ForestAnimals" �̸� ����
        {
            //Right �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/Right_and_Wrong").transform);

            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal"; //Ŭ���� ��ư�� �±װ� "CorrectAnimal" ���� ����
            number_of_Correctanimals++; //���� ������ �� 1����
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals") // Ŭ���� ��ư�� �±װ� "CorrectAnimal"�� "ForestAnimals"�� �ƴ϶�� ����
        {
            //wrong �� Ŭ���� ��ư ��ġ���� Ŭ���� ��ư ȸ�������� Hierarchyâ Canvas�ȿ� ��ȯ
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/Right_and_Wrong").transform);
        }
    }
}