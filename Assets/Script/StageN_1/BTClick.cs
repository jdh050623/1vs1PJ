using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BTClick : MonoBehaviour
{
    public AudioClip WBTclip;
    IEnumerator coru;
    private bool once = false;
    public void RightButton()
    {
        if(once == false || GameManagerN_0.instance.Second == true)
        {
            GameManagerN_0.instance.Clear++;
            once = true;
        }    
    }

    public void WrongButton()
    {
        Sound.instance.SoundPlay("Credit", WBTclip);
    }
}
