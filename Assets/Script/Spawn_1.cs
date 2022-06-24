using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_1 : MonoBehaviour //스테이지 n-1의 스폰 스크립트
{
    public GameObject Animal_1;
    public GameObject Animal_2;
    public GameObject[] WrongAnimal;
    public GameObject[] Shadow;

    public int Num;

    public Transform[] SpawnPoints;
    public Transform SpawnShadow;

    int ranAnimal;
    int ranAnimal1;
    int ranPoint;
    int ranPoint1;
    int ranPoint2;
    int ranPoint3;
    int ranShadowpoint;

    // Start is called before the first frame update
    void Start()
    {
        SpawnAnimal();

    }

    void SpawnAnimal()
    {
        ranAnimal = Random.Range(0, Num);
        ranAnimal1 = Random.Range(0, Num);
        ranPoint = Random.Range(0, 7);
        ranPoint1 = Random.Range(0, 7);
        ranPoint2 = Random.Range(0, 7);
        ranPoint3 = Random.Range(0, 7);
        ranShadowpoint = Random.Range(0, 2);

        while (ranPoint == ranPoint1 || ranPoint == ranPoint2 || ranPoint == ranPoint3 || ranPoint1 == ranPoint2 || ranPoint1 == ranPoint3 || ranPoint2 == ranPoint3)
        {
            ranPoint = Random.Range(0, 7);
            ranPoint1 = Random.Range(0, 7);
            ranPoint2 = Random.Range(0, 7);
            ranPoint3 = Random.Range(0, 7);
        }
        Debug.Log(ranPoint);
        Debug.Log(ranPoint1);
        Debug.Log(ranPoint2);
        Debug.Log(ranPoint3);

        Shadow[ranShadowpoint].SetActive(true);
        Instantiate(WrongAnimal[ranAnimal], SpawnPoints[ranPoint].position, SpawnPoints[ranPoint].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(WrongAnimal[ranAnimal1], SpawnPoints[ranPoint3].position, SpawnPoints[ranPoint3].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(Animal_1, SpawnPoints[ranPoint1].position, SpawnPoints[ranPoint1].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(Animal_2, SpawnPoints[ranPoint2].position, SpawnPoints[ranPoint2].rotation, GameObject.Find("Canvas/OBGGroup").transform);

    }

}
