using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint2 : MonoBehaviour
{
    public GameObject HintOBJ;
    float HintTime;
    public Stage0N_01 stage0N_01;
    bool HintSp = false;
    bool OneSpawn1;

    IEnumerator coru1;

    // Start is called before the first frame update
    void Start()
    {
        HintTime = 5;
        coru1 = timeStop();
        StartCoroutine(coru1);
        OneSpawn1 = false;
        
    }
    public void Update()
    {
        if (stage0N_01.HintStop == true)
        {
            HintOBJ.SetActive(false);
        }
    }

    IEnumerator timeStop()
    {
        Debug.Log("»˘∆Æ ¿€µø¡ﬂ111111");
        float dTime = 0;
        while (dTime < HintTime || OneSpawn1 == false)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            dTime += Time.deltaTime;

            if (dTime < HintTime)
            {
                OneSpawn1 = true;
            }
        }
        Debug.Log("»˘∆Æ º“»Ø");
        if (stage0N_01.HintStop == false)
        {
            HintOBJ.SetActive(true);
        }
        

        dTime = 0;
        StopCoroutine(coru1);
    }
}
