using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage0n_0 : MonoBehaviour //스테이지 n-1 의 스폰 시스템
{
    [Header("단어 위치")]
    public Transform[] ThreeSpawn;

    [Header("단어 버튼")]
    public GameObject[] WordButton_1;
    public GameObject[] WordButton_2;

    [Header("쓰레기")]
    public int WordNum_1;
    public int WordNum_2;
    
    public Transform TargetPos_1;
    public Transform TargetPos_2;

    public Transform PassAnimal;
    public GameObject NextAnimal;

    bool first = true;
    int ranWord_1;
    int ranWord_2;
    int ranWord_3;

    int ranPoint_1;
    int ranPoint_2;
    int ranPoint_3;

    IEnumerator coru;

    void Start()
    {
        WordSpawn_1();
    }
    void Update()
    {
        Clear();
    }
    void WordSpawn_1()
    {
        while (ranPoint_1 == ranPoint_2 || ranPoint_1 == ranPoint_3 || ranPoint_2 == ranPoint_3)
        {
            ranPoint_1 = Random.Range(0, WordNum_1);
            ranPoint_2 = Random.Range(0, WordNum_1);
            ranPoint_3 = Random.Range(0, WordNum_1);
        }
        
        while (ranWord_1 == ranWord_2 || ranWord_1 == ranWord_3 || ranWord_2 == ranWord_3)
        { 
            ranWord_1 = Random.Range(0, WordNum_1);
            ranWord_2 = Random.Range(0, WordNum_1);
            ranWord_3 = Random.Range(0, WordNum_1);
        }

        Instantiate(WordButton_1[ranWord_1], ThreeSpawn[ranPoint_1].position, ThreeSpawn[ranPoint_1].rotation, GameObject.FindWithTag("OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_2], ThreeSpawn[ranPoint_2].position, ThreeSpawn[ranPoint_2].rotation, GameObject.FindWithTag("OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_3], ThreeSpawn[ranPoint_3].position, ThreeSpawn[ranPoint_3].rotation, GameObject.FindWithTag("OBJGroup").transform);
    }
    void WordSpawn_2()
    {
        GameManagerN_0.instance.Second = true;
        NextAnimal.SetActive(true);

        while (ranPoint_1 == ranPoint_2 || ranPoint_1 == ranPoint_3 || ranPoint_2 == ranPoint_3)
        {
            ranPoint_1 = Random.Range(0, WordNum_2);
            ranPoint_2 = Random.Range(0, WordNum_2);
            ranPoint_3 = Random.Range(0, WordNum_2);
        }

        while (ranWord_1 == ranWord_2 || ranWord_1 == ranWord_3 || ranWord_2 == ranWord_3)
        {
            ranWord_1 = Random.Range(0, WordNum_2);
            ranWord_2 = Random.Range(0, WordNum_2);
            ranWord_3 = Random.Range(0, WordNum_2);
        }

        Instantiate(WordButton_2[ranWord_1], ThreeSpawn[ranPoint_1].position, ThreeSpawn[ranPoint_1].rotation, GameObject.FindWithTag("OBJGroup2").transform);
        Instantiate(WordButton_2[ranWord_2], ThreeSpawn[ranPoint_2].position, ThreeSpawn[ranPoint_2].rotation, GameObject.FindWithTag("OBJGroup2").transform);
        Instantiate(WordButton_2[ranWord_3], ThreeSpawn[ranPoint_3].position, ThreeSpawn[ranPoint_3].rotation, GameObject.FindWithTag("OBJGroup2").transform);
    }
    void Clear()
    {
        if (GameManagerN_0.instance.Clear == 1&&first==true)
        {
            coru = timeStop();
            first = false;
            StartCoroutine(coru);
            
        }
    }
    IEnumerator timeStop()
    {
        float dTime = 0;
        while (dTime<1f)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            dTime += Time.deltaTime;
            PassAnimal.transform.position = Vector3.Lerp(PassAnimal.transform.position, TargetPos_1.position, 0.02f);
        Debug.Log(dTime);
        }
        dTime = 0;
        yield return new WaitForSeconds(0.01f);
        while (dTime < 2f)
        {
            dTime += Time.deltaTime;
            PassAnimal.transform.position = Vector3.Lerp(PassAnimal.transform.position, TargetPos_2.position, 0.01f);
            yield return new WaitForSeconds(Time.deltaTime);
        }
        WordSpawn_2();
        StopCoroutine(coru);
    }
}
