using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW_Move : MonoBehaviour
{
    float distance = 10;

    private void OnMouseDrag() //드래그를 할 수 있게 해주는 코드이다 쓰기 위해선 이미지에 Collider를 추가해야 한다.
    {
        
            Debug.Log("드래그 적용중");
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); transform.position = objPosition;
        
    }

}
