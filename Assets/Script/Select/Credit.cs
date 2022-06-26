using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CreditBT_;

    public void CreditGo()
    {
        CreditBT_.SetActive(true);
    }
    public void CreditOut()
    {
        CreditBT_.SetActive(false);
    }
}
