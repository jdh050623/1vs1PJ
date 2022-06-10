using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01_0 : MonoBehaviour
{
    [Header("2글자 위치")]
    public Transform[] TwoSpawn;

    [Header("3글자 위치")]
    public Transform[] ThreeSpawn;

    [Header("4글자 위치")]
    public Transform[] FourSpawn;

    [Header("단어 버튼")]
    public GameObject[] WordButton_1;
    public GameObject[] WordButton_2;

    [Header("글자 수 정하기")]
    public int WordNum_1;
    public int WordNum_2;

    int ranWord_1;
    int ranWord_2;
    int ranWord_3;
    int ranWord_4;
    int ranPoint_1;
    int ranPoint_2;
    int ranPoint_3;
    int ranPoint_4;

    bool n_0Clear;
    void Start()
    {
        if (WordNum_1 == 2)
        {
            Two_Letters_1();
        }
        else if(WordNum_1 == 3)
        {
            Three_Letters_1();
        }
        else if(WordNum_1 == 4)
        {
            Four_Letters_1();
        }
    }
    void Update()
    {
        if (n_0Clear == true)
        {
            if (WordNum_2 == 2)
            {
                Two_Letters_2();
            }
            else if (WordNum_2 == 3)
            {
                Three_Letters_2();
            }
            else if (WordNum_2 == 4)
            {
                Four_Letters_1();
            }
        }  
    }
    void Two_Letters_1()
    {
        while (ranPoint_1 == ranPoint_2)
        {
            ranPoint_1 = Random.Range(0, WordNum_1);
            ranPoint_2 = Random.Range(0, WordNum_1);
        }

        while (ranWord_1 == ranWord_2)
        {
            ranWord_1 = Random.Range(0, WordNum_1);
            ranWord_2 = Random.Range(0, WordNum_1);
        }

        Instantiate(WordButton_1[ranWord_1], TwoSpawn[ranPoint_1].position, TwoSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_2], TwoSpawn[ranPoint_2].position, TwoSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
    }
    void Three_Letters_1()
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

        Instantiate(WordButton_1[ranWord_1], ThreeSpawn[ranPoint_1].position, ThreeSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_2], ThreeSpawn[ranPoint_2].position, ThreeSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_3], ThreeSpawn[ranPoint_3].position, ThreeSpawn[ranPoint_3].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
    }
    void Four_Letters_1()
    {
        while (ranPoint_1 == ranPoint_2 || ranPoint_1 == ranPoint_3 || ranPoint_1 == ranPoint_4 || ranPoint_2 == ranPoint_3 || ranPoint_2 == ranPoint_4 || ranPoint_3 == ranPoint_4)
        {

            ranPoint_1 = Random.Range(0, WordNum_1);
            ranPoint_2 = Random.Range(0, WordNum_1);
            ranPoint_3 = Random.Range(0, WordNum_1);
            ranPoint_4 = Random.Range(0, WordNum_1);
        }

        while (ranWord_1 == ranWord_2 || ranWord_1 == ranWord_3 || ranWord_1 == ranWord_4 || ranWord_2 == ranWord_3 || ranWord_2 == ranWord_4 || ranWord_3 == ranWord_4)
        {

            ranWord_1 = Random.Range(0, WordNum_1);
            ranWord_2 = Random.Range(0, WordNum_1);
            ranWord_3 = Random.Range(0, WordNum_1);
            ranWord_4 = Random.Range(0, WordNum_1);
        }

        Instantiate(WordButton_1[ranWord_1], FourSpawn[ranPoint_1].position, FourSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_2], FourSpawn[ranPoint_2].position, FourSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_3], FourSpawn[ranPoint_3].position, FourSpawn[ranPoint_3].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
        Instantiate(WordButton_1[ranWord_4], FourSpawn[ranPoint_4].position, FourSpawn[ranPoint_4].rotation, GameObject.Find("Canvas/Raccons/OBJGroup").transform);
    }

    void Two_Letters_2()
    {
        while (ranPoint_1 == ranPoint_2)
        {
            ranPoint_1 = Random.Range(0, WordNum_2);
            ranPoint_2 = Random.Range(0, WordNum_2);
        }

        while (ranWord_1 == ranWord_2)
        {
            ranWord_1 = Random.Range(0, WordNum_2);
            ranWord_2 = Random.Range(0, WordNum_2);
        }

        Instantiate(WordButton_2[ranWord_1], TwoSpawn[ranPoint_1].position, TwoSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_2], TwoSpawn[ranPoint_2].position, TwoSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/OBJGroup").transform);
    }
    void Three_Letters_2()
    {
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

        Instantiate(WordButton_2[ranWord_1], ThreeSpawn[ranPoint_1].position, ThreeSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_2], ThreeSpawn[ranPoint_2].position, ThreeSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_3], ThreeSpawn[ranPoint_3].position, ThreeSpawn[ranPoint_3].rotation, GameObject.Find("Canvas/OBJGroup").transform);
    }
    void Four_Letters_2()
    {
        while (ranPoint_1 == ranPoint_2 || ranPoint_1 == ranPoint_3 || ranPoint_1 == ranPoint_4 || ranPoint_2 == ranPoint_3 || ranPoint_2 == ranPoint_4 || ranPoint_3 == ranPoint_4)
        {

            ranPoint_1 = Random.Range(0, WordNum_2);
            ranPoint_2 = Random.Range(0, WordNum_2);
            ranPoint_3 = Random.Range(0, WordNum_2);
            ranPoint_4 = Random.Range(0, WordNum_2);
        }

        while (ranWord_1 == ranWord_2 || ranWord_1 == ranWord_3 || ranWord_1 == ranWord_4 || ranWord_2 == ranWord_3 || ranWord_2 == ranWord_4 || ranWord_3 == ranWord_4)
        {

            ranWord_1 = Random.Range(0, WordNum_2);
            ranWord_2 = Random.Range(0, WordNum_2);
            ranWord_3 = Random.Range(0, WordNum_2);
            ranWord_4 = Random.Range(0, WordNum_2);
        }

        Instantiate(WordButton_2[ranWord_1], FourSpawn[ranPoint_1].position, FourSpawn[ranPoint_1].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_2], FourSpawn[ranPoint_2].position, FourSpawn[ranPoint_2].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_3], FourSpawn[ranPoint_3].position, FourSpawn[ranPoint_3].rotation, GameObject.Find("Canvas/OBJGroup").transform);
        Instantiate(WordButton_2[ranWord_4], FourSpawn[ranPoint_4].position, FourSpawn[ranPoint_4].rotation, GameObject.Find("Canvas/OBJGroup").transform);
    }
}
