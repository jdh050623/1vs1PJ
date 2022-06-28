using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public AudioClip BTclip;
    // Start is called before the first frame update
    public GameObject CreditBT_;

    public void CreditGo()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        CreditBT_.SetActive(true);
    }
    public void CreditOut()
    {
        CreditBT_.SetActive(false);
    }
}
