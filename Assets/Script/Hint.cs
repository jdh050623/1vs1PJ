using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour //힌트를 주는 스크립트
{
    public GameObject HintOBJ;
    public float HintTime;

    bool OneSpawn;

    IEnumerator coru;
    // Start is called before the first frame update
    void Start()
    {
        coru = timeStop();
        StartCoroutine(coru);
        OneSpawn = false;
        
    }

    private void Update()
    {

    }
    IEnumerator timeStop()
    {
        Debug.Log("힌트 작동중111111");
        float dTime = 0;
        while (dTime < HintTime || OneSpawn == false)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            dTime += Time.deltaTime;
            
            if(dTime < HintTime)
            {
                OneSpawn = true;
            }
        }
        Debug.Log("힌트 소환");
        HintOBJ.SetActive(true);
        dTime = 0;
        StopCoroutine(coru);
    }
}
