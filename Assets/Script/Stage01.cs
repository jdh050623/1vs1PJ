using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stage01 : MonoBehaviour
{
    public GameObject Right; //클릭한 동물이 스테이지에 맞는 동물일때 나오는 오브젝트
    public GameObject Wrong; //클릭한 동물이 스테이지에 틀린 동물일때 나오는 오브젝트
    public GameObject Clear;

    float number_of_Correctanimals = 0; // 맞춘 동물의 수

    private void Update()
    {
        if(number_of_Correctanimals == 2)
        {
            Clear.SetActive(true);
        }
    }

    public void AnimalClick()//동물을 클릭했을때
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals")
        {
            //Right 를 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //맞춘 동물의 수 1증가
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals")
        {
            //wrong 을 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
                
            Debug.Log("d");
        }

    }
    IEnumerator Corutin()
    {
        yield return new WaitForSeconds(3);
    }
}