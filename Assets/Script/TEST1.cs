using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    public GameObject Animal_1;
    public GameObject Animal_2;
    public GameObject NoAnimal_1;
    public GameObject NoAnimal_2;

    public Transform SpawnPos_1;
    public Transform SpawnPos_2;
    public Transform SpawnPos_3;
    public Transform SpawnPos_4;
    public Transform SpawnPos_5;
    public Transform SpawnPos_6;
    public Transform SpawnPos_7;

    int Spawn1;
    int Spawn2;
    int Spawn3;
    int Spawn4;
    // Start is called before the first frame update
    void Start()
    {
        RandomIndex();
        Spawn();
    }

    void RandomIndex()
    {
        Spawn1 = Random.Range(0, 8);
        Spawn2 = Random.Range(0, 8);
        Spawn3 = Random.Range(0, 8);
        Spawn4 = Random.Range(0, 8);

        while (Spawn1 == Spawn2 || Spawn1 == Spawn3 || Spawn1 == Spawn4 || Spawn2 == Spawn3 || Spawn2 == Spawn4 || Spawn3 == Spawn4)
        {
            Spawn2 = Random.Range(0, 8);
            Spawn3 = Random.Range(0, 8);
            Spawn4 = Random.Range(0, 8);
        }

        Debug.Log("" + Spawn1);
        Debug.Log("" + Spawn2);
        Debug.Log("" + Spawn3);
        Debug.Log("" + Spawn4);
    }

    void Spawn()
    {
        if(Spawn1 == 0)
        {
            Instantiate(Animal_1, SpawnPos_1.position, SpawnPos_1.rotation, GameObject.Find("Canvas/ClickObj").transform);
        }
        
    }
}
