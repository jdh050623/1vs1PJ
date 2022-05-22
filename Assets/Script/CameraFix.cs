using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour // 16:9 ����� ȭ������ϴ� ��ũ��Ʈ
{
    float Scaleheight;
    float Scalewidth;
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;

        Scaleheight = ((float)Screen.width / Screen.height) / ((float)16 / 9); //���� / ����
        Scalewidth = 1f / Scaleheight;
        if(Scaleheight < 1)
        {
            rect.height = Scaleheight;
            rect.y = (1f - Scaleheight) / 2f;
        }
        else
        {
            rect.width = Scalewidth;
            rect.x = (1f - Scalewidth) / 2f;
        }
        camera.rect = rect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
