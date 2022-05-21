using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//유니티 엔진의 이벤트 시스템을 불러옴

public class Stage01 : MonoBehaviour
{
    public GameObject Right; //클릭한 동물이 스테이지에 맞는 동물일때 나오는 오브젝트
    public GameObject Wrong; //클릭한 동물이 스테이지에 틀린 동물일때 나오는 오브젝트

    float number_of_Correctanimals = 0; // 맞춘 동물의 수

    public void AnimalClick()//동물을 클릭했을때
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals")// 클릭한 버튼의 태그가 "ForestAnimals" 이면 실행
        {
            //Right 를 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);

            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal"; //클릭한 버튼의 태그가 "CorrectAnimal" 으로 변경
            number_of_Correctanimals++; //맞춘 동물의 수 1증가
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals") // 클릭한 버튼의 태그가 "CorrectAnimal"와 "ForestAnimals"가 아니라면 실행
        {
            //wrong 을 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            Instantiate(Wrong, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas").transform);
        }
    }
}