using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwich : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject SoundOff;
    public void SoundOnClick()
    {

        Sound.instance.isMuted = true;
    }

    public void SoundOffClick()
    {
        Sound.instance.isMuted = false;
    }

    public void Update()
    {
        if (Sound.instance.isMuted == true)
        {
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            AudioListener.pause = Sound.instance.isMuted;
        }

        if (Sound.instance.isMuted == false)
        {
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
            AudioListener.pause = Sound.instance.isMuted;
        }
    }
    



}
