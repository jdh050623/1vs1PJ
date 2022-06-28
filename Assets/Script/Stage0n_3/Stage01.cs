using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stage01 : MonoBehaviour
{
    IEnumerator coru;

    public GameObject Right; //클릭한 동물이 스테이지에 맞는 동물일때 나오는 오브젝트
    public GameObject Wrong; //클릭한 동물이 스테이지에 틀린 동물일때 나오는 오브젝트
    public GameObject Clear; //클리어 했을때 나오는 창

    public GameObject Ani1;
    public GameObject Ani2;

    private bool ClearTrue = false; //클리어 했을때 클리어 창이 계속 뜨지 않게 해주는 것
    private bool Click = false;//틀렸을때 클릭의 쿨타임 조건

    float number_of_Correctanimals = 0; // 맞춘 동물의 수

    private void Update()
    {
        if (number_of_Correctanimals == 2 && ClearTrue == false)
        {
            AniTime();
            Clear.SetActive(true);
            ClearTrue = true;
        }
    }

    public void AnimalClick()//동물을 클릭했을때
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals" && Click == false)
        {
            //Right 를 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            
            Instantiate(Ani1, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //맞춘 동물의 수 1증가

            Destroy(EventSystem.current.currentSelectedGameObject);
        }

        if (EventSystem.current.currentSelectedGameObject.tag == "ForestAnimals2" && Click == false)
        {
            //Right 를 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
            Instantiate(Ani2, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            Instantiate(Right, EventSystem.current.currentSelectedGameObject.transform.position, EventSystem.current.currentSelectedGameObject.transform.rotation, GameObject.Find("Canvas/ClickObj").transform);
            
            EventSystem.current.currentSelectedGameObject.tag = "CorrectAnimal";
            number_of_Correctanimals++; //맞춘 동물의 수 1증가
            Destroy(EventSystem.current.currentSelectedGameObject);
        }

        if (EventSystem.current.currentSelectedGameObject.tag != "CorrectAnimal" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals" && EventSystem.current.currentSelectedGameObject.tag != "ForestAnimals2" && Click == false)
        {
            Click = true;
            //wrong 을 클릭한 버튼 위치값에 클릭한 버튼 회전값으로 Hierarchy창 Canvas안에 소환
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