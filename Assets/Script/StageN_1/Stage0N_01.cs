using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage0N_01 : MonoBehaviour //스테이지 N-1 스테이지 스크립트
{
    public static Stage0N_01 instance = null;
    public bool HintStop = false;

    [Header("이동 위치")]
    public Vector3 AnimalPos;
    public Vector3 WordPos;

    public Vector3 TargetPos_1;
    public Vector3 TargetPos_2;

    public Vector3 BTTargetPos_3;

    [Header("게임 오브젝트")]
    //public GameObject NextAnimal;

    public GameObject HintZone1;
    public GameObject HintZone2;

    public GameObject Animal1;
    public GameObject Ani1;

    public GameObject Animal2;
    public GameObject Ani2;

    public GameObject Word;
    public GameObject Word2;

    public GameObject End;

    Vector3 Ani_1 = Vector3.zero;
    Vector3 Word_1 = Vector3.zero; // (0,0,0) 은 .zero 로도 표현가능
    Vector3 Animal_2 = Vector3.zero;
    Vector3 Word_2 = Vector3.zero;

    int AnimalClick = 0;

    bool end = false;
    bool end2 = false;
    bool end3 = false;
    bool end4 = false;

    //코루틴 관련
    IEnumerator coru;
    public float MTime;
    bool OneSpawn;

    // Start is called before the first frame update
    //----------------

    public GameObject RightWord1;
    public GameObject RightWord2;

    public List<GameObject> WrongWord1;
    
    public List<GameObject> WrongWord2;

    public List<Transform> SpawnPoints;
    public List<Transform> SpawnPoints2;

    int randRG;//단어 오브젝트 랜덤
    int randWG;// 틀린 단어 오브젝트랜덤
    int randST1;// 스폰 트렌스폼 랜덤

    int randRG2;//단어 오브젝트 랜덤
    int randWG2;// 틀린 단어 오브젝트랜덤
    int randST2;// 스폰 트렌스폼 랜덤
    //int randST2;// 스폰 트렌스폼 랜덤
    // Start is called before the first frame update
    void Start()
    {

         randWG = Random.Range(0, 1);
         randST1 = Random.Range(0, SpawnPoints.Count);
         Instantiate(RightWord1, SpawnPoints[randST1].position, SpawnPoints[randST1].rotation, GameObject.Find("Canvas/OBJGroup/Word1").transform);  
         SpawnPoints.RemoveAt(randST1);

        
        for (int i = 0; i < 2; i++)
        {
            randRG = Random.Range(0, WrongWord1.Count);
            randST1 = Random.Range(0, SpawnPoints.Count);
            Instantiate(WrongWord1[randRG], SpawnPoints[randST1].position, SpawnPoints[randST1].rotation, GameObject.Find("Canvas/OBJGroup/Word1").transform);
            WrongWord1.RemoveAt(randRG);
            SpawnPoints.RemoveAt(randST1);
        }

        randWG2 = Random.Range(0, 1);
        randST2 = Random.Range(0, SpawnPoints2.Count);
        Instantiate(RightWord2, SpawnPoints2[randST2].position, SpawnPoints2[randST2].rotation, GameObject.Find("Canvas/OBJGroup/Word2").transform);
        SpawnPoints2.RemoveAt(randST2);

        for (int i = 0; i < 2; i++)
        {
            randRG2 = Random.Range(0, WrongWord2.Count);
            randST2 = Random.Range(0, SpawnPoints2.Count);
            Instantiate(WrongWord2[randRG2], SpawnPoints2[randST2].position, SpawnPoints2[randST2].rotation, GameObject.Find("Canvas/OBJGroup/Word2").transform);
            WrongWord2.RemoveAt(randRG2);
            SpawnPoints2.RemoveAt(randST2);
        }

        Word2.SetActive(false);
        Animal2.SetActive(false);

    }
    // Update is called once per frame

    void Update()
    {


        //MoveAni1();
        if (AnimalClick == 1)
        {
            if (end == false)
            {
                Animal1.SetActive(false);
                Ani1.SetActive(true);
                
            }
            if (end3 == false)
            {
                HintStop = true;
                end3 = true;
            }
            
            coru = TimeStop_1();

            StartCoroutine(coru);
            //Ani1.transform.position = Vector3.SmoothDamp(Ani1.transform.position, TargetPos_1, ref vel, 1f);


            Debug.Log("dasdsa");

        }
        if (AnimalClick == 2)
        {
            
            Animal2.SetActive(false);
            Ani2.SetActive(true);
            if(end4 == false)
            {
                HintStop = true;
                end4 = true;
            }
            
            coru = TimeStop_2();
            StartCoroutine(coru);
        }
    }

    public void AnimalBT1()
    {

        AnimalClick = 1;
    }

    public void AnimalBT2()
    {

        AnimalClick = 2;
    }

    /*void MoveAni1()
    {
        if(AnimalClick == 1)
        {
            coru = TimeStop_1();
            first = false;
            StartCoroutine(coru);
            AnimalClick = 0;
        }
            
    }*/

    IEnumerator TimeStop_1()
    {
        yield return new WaitForSeconds(5f);
        Word.transform.position = Vector3.Lerp(Word.transform.position, BTTargetPos_3, 0.01f);
        Ani1.transform.position = Vector3.Lerp(Ani1.transform.position, TargetPos_2, 0.01f);
        if (end == false)
        {
            yield return new WaitForSeconds(1f);
        }

        end = true;
        Word.SetActive(false);
        Ani1.SetActive(false);

        Word2.transform.position = Vector3.Lerp(Word2.transform.position, WordPos, 0.01f);
        Animal2.transform.position = Vector3.Lerp(Animal2.transform.position, AnimalPos, 0.01f);

        if (end2 == false)
        {
            Word2.SetActive(true);
            Animal2.SetActive(true);
            HintStop = false;
            Word2.transform.position = Vector3.Lerp(Word2.transform.position, WordPos, 0.01f);
            Animal2.transform.position = Vector3.Lerp(Animal2.transform.position, AnimalPos, 0.01f);
            end2 = true;
        }

        
        StopCoroutine(coru);
    }

    IEnumerator TimeStop_2()
    {
        yield return new WaitForSeconds(5f);
/*        Word2.transform.position = Vector3.Lerp(Word2.transform.position, BTTargetPos_3, 0.01f);
        Ani2.transform.position = Vector3.Lerp(Ani2.transform.position, TargetPos_2, 0.01f);*/
        /*if (end == true)
        {
            yield return new WaitForSeconds(2f);
            end = false;
        }*/
        End.SetActive(true);

        StopCoroutine(coru);

    }

}
