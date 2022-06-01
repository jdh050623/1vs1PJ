using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    float distance = 10;

    bool DragOn = false;//드래그를 하는중일때 켜지는 함수
    bool DragOut = false;//드래그를 못하게 하는 함수
    bool Clear = false;//클리어 했을때 켜지는 함수

    public Vector3 StartZone;
    
    //public Vector3 ClearZone;

    public GameObject AnimalShadow;
    public GameObject Animal;
    private void Update()
    {
        GoBack();
        ClearAni();
    }
    private void OnMouseDrag() //드래그를 할 수 있게 해주는 코드이다 쓰기 위해선 이미지에 Collider를 추가해야 한다.
    {
        if(DragOut == false)
        {
            //Debug.Log("드래그 적용중");
            DragOn = true;
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); transform.position = objPosition;
        }
    }
    private void OnMouseUp()
    {
        //Debug.Log("드래그 중지");
        DragOn = false;
    }

    private void GoBack()//드래그를 놓았을때 오브젝트를 원래 장소로 돌아가게 해줌
    {
        if (DragOn == false && Clear == false)//
        {
            Vector3 velo = Vector3.zero;
            transform.position = Vector3.SmoothDamp(transform.position, StartZone, ref velo, 0.05f);
        }
    }
    private void ClearAni()//
    {
        if(Clear == true)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x,transform.position.y,transform.position.z), new Vector3(AnimalShadow.transform.position.x, AnimalShadow.transform.position.y, -0.1f), 0.05f);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)//
    {
        //if(collision.name == "Owl")
        if(collision.gameObject == AnimalShadow)
        {
            Clear = true;
            DragOut = true;
            Debug.Log("클리어");
        }
        
    }
}
