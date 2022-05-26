using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongDestroy : MonoBehaviour //1초후 틀린 표시를 삭제하는 스크립트
{
    void Update()
    {
        Destroy(gameObject,1);
    }
}
