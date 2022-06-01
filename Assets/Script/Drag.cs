using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    float distance = 10;

    bool DragOn = false;//�巡�׸� �ϴ����϶� ������ �Լ�
    bool DragOut = false;//�巡�׸� ���ϰ� �ϴ� �Լ�
    bool Clear = false;//Ŭ���� ������ ������ �Լ�

    public Vector3 StartZone;
    
    //public Vector3 ClearZone;

    public GameObject AnimalShadow;
    public GameObject Animal;
    private void Update()
    {
        GoBack();
        ClearAni();
    }
    private void OnMouseDrag() //�巡�׸� �� �� �ְ� ���ִ� �ڵ��̴� ���� ���ؼ� �̹����� Collider�� �߰��ؾ� �Ѵ�.
    {
        if(DragOut == false)
        {
            //Debug.Log("�巡�� ������");
            DragOn = true;
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); transform.position = objPosition;
        }
    }
    private void OnMouseUp()
    {
        //Debug.Log("�巡�� ����");
        DragOn = false;
    }

    private void GoBack()//�巡�׸� �������� ������Ʈ�� ���� ��ҷ� ���ư��� ����
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
            Debug.Log("Ŭ����");
        }
        
    }
}
