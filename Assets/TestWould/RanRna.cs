using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanRna : MonoBehaviour
{
    public List<GameObject> dasd;
    public List<Transform> AAA;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
           int rand = Random.Range(0, dasd.Count);
           int randA = Random.Range(0, AAA.Count);
           print(dasd[rand]);
           print(AAA[randA]);
           Instantiate(dasd[rand], AAA[randA].position, AAA[randA].rotation);
           dasd.RemoveAt(rand);
           AAA.RemoveAt(randA);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
