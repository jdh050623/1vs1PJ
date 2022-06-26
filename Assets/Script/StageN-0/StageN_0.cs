using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageN_0 : MonoBehaviour
{
    [Header("이동 위치")]
    public Vector3 AnimalPos;
    public Vector3 WordPos;

    public Vector3 TargetPos_1;
    public Vector3 TargetPos_2;

    public Vector3 BTTargetPos_3;

    [Header("게임 오브젝트")]
    //public GameObject NextAnimal;

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

    bool Stop = false;
    bool end = false;
    bool end2 = false;

    //코루틴 관련
    IEnumerator coru;
    public float MTime;
    bool OneSpawn;
    // Start is called before the first frame update

    void Start()
    {

        
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

            coru = TimeStop_1();

            StartCoroutine(coru);
            //Ani1.transform.position = Vector3.SmoothDamp(Ani1.transform.position, TargetPos_1, ref vel, 1f);


            Debug.Log("dasdsa");



        }
        if (AnimalClick == 2)
        {
            
                Animal2.SetActive(false);
                Ani2.SetActive(true);
                
            
            coru = TimeStop_2();
            StartCoroutine(coru);

        }
    
    }

    public void AnimalBT1()
    {
        
        AnimalClick=1;
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
        Word.transform.position = Vector3.Lerp(Word.transform.position, BTTargetPos_3,0.01f);
        Ani1.transform.position = Vector3.Lerp(Ani1.transform.position, TargetPos_2, 0.01f);
        if(end == false)
        {
            yield return new WaitForSeconds(1f);
        }
        
        end = true;
        Word.SetActive(false);
        Ani1.SetActive(false);
        
        Word2.transform.position = Vector3.Lerp(Word2.transform.position, WordPos, 0.01f);
        Ani1.transform.position = Vector3.Lerp(Ani1.transform.position, AnimalPos, 0.01f);
        if (end2 == false)
        {
            Word2.SetActive(true);
            Animal2.SetActive(true);
            end2 = true;
        }
            
        Word2.transform.position = Vector3.Lerp(Word2.transform.position, WordPos, 0.01f);
        Animal2.transform.position = Vector3.Lerp(Animal2.transform.position, AnimalPos, 0.01f);
        StopCoroutine(coru);
    }

    IEnumerator TimeStop_2()
    {
        yield return new WaitForSeconds(5f);
        Word.transform.position = Vector3.Lerp(Word.transform.position, BTTargetPos_3, 0.01f);
        Ani1.transform.position = Vector3.Lerp(Ani1.transform.position, TargetPos_2, 0.01f);
        if (end == true)
        {
            yield return new WaitForSeconds(2f);
            end = false;
        }
        End.SetActive(true);
  
        StopCoroutine(coru);

    }
}
