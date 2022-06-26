using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSpawn : MonoBehaviour
{
    public GameObject[] Shadow;

    int ranShadowpoint;
    // Start is called before the first frame update
    void Start()
    {
        ranShadowpoint = Random.Range(0, 2);
        Shadow[ranShadowpoint].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
