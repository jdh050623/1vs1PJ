using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW_Move : MonoBehaviour
{
    float distance = 10;

    private void OnMouseDrag() //�巡�׸� �� �� �ְ� ���ִ� �ڵ��̴� ���� ���ؼ� �̹����� Collider�� �߰��ؾ� �Ѵ�.
    {
        
            Debug.Log("�巡�� ������");
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); transform.position = objPosition;
        
    }

}
