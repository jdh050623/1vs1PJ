using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassAnimal : MonoBehaviour
{
    public Vector3 TargetPos_1;
    public Vector3 TargetPos_2;

    public GameObject NextAnimal;

    Vector3 vel = Vector3.zero;

    bool Stop = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManagerN_0.instance.Clear == 1)
        {
            transform.position = Vector3.SmoothDamp(NextAnimal.transform.position, TargetPos_1, ref vel, 2f);
            TimeStop();
            if (Stop == false) transform.position = Vector3.SmoothDamp(TargetPos_1, TargetPos_2, ref vel, 2f);
        }
    }
    IEnumerable TimeStop()
    {
        yield return new WaitForSeconds(2);
    }
}
