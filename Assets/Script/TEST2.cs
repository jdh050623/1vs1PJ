using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST2 : MonoBehaviour
{
    public GameObject Animal_1;
    public GameObject Animal_2;
    public GameObject[] WrongAnimal;
    public Transform[] SpawnPoints;

    int ranAnimal;
    int ranPoint;
    int ranPoint1;
    int ranPoint2;
    int ranPoint3;

    // Start is called before the first frame update
    void Start()
    { 
         SpawnAnimal();

    }

    void SpawnAnimal()
    {
        ranAnimal = Random.Range(0, 2);
        ranPoint  = Random.Range(0, 7);
        ranPoint1 = Random.Range(0, 7);
        ranPoint2 = Random.Range(0, 7);
        ranPoint3 = Random.Range(0, 7);

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


        Instantiate(WrongAnimal[ranAnimal], SpawnPoints[ranPoint].position, SpawnPoints[ranPoint].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(WrongAnimal[ranAnimal], SpawnPoints[ranPoint3].position, SpawnPoints[ranPoint3].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(Animal_1, SpawnPoints[ranPoint1].position, SpawnPoints[ranPoint1].rotation, GameObject.Find("Canvas/OBGGroup").transform);
        Instantiate(Animal_2, SpawnPoints[ranPoint2].position, SpawnPoints[ranPoint2].rotation, GameObject.Find("Canvas/OBGGroup").transform);
    }

    IEnumerator Corutin()
    {
        yield return new WaitForSeconds(3);
    }
}
