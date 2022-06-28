using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour //버튼 관련 스크립트
{
    public GameObject Out;
    public AudioClip BTclip;

    public void BT01_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT01_0_", 0.2f);
        
    }
    public void BT01_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT01_1_", 0.2f);
        
    }
    public void BT01_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT01_2_", 0.2f);
        
    }
    public void BT01_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT01_3_", 0.2f);
        
    }
    public void BT02_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT02_0_", 0.2f);
        
    }
    public void BT02_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT02_1_", 0.2f);
        
    }
    public void BT02_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT02_2_", 0.2f);
        
    }
    public void BT02_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT02_3_", 0.2f);
        
    }
    public void BT03_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT03_0_", 0.2f);
        
    }
    public void BT03_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT03_1_", 0.2f);
        
    }
    public void BT03_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT03_2_", 0.2f);
        
    }
    public void BT03_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT03_3_", 0.2f);
        
    }
    public void BT04_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT04_0_", 0.2f);
        
    }
    public void BT04_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT04_1_", 0.2f);
        
    }
    public void BT04_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT04_2_", 0.2f);
        
    }
    public void BT04_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT04_3_", 0.2f);
        
    }
    public void BT05_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT05_0_", 0.2f);
        
    }
    public void BT05_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT05_1_", 0.2f);
        
    }
    public void BT05_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT05_2_", 0.2f);
        
    }
    public void BT05_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT05_3_", 0.2f);
        
    }
    public void BT06_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT06_0_", 0.2f);
        
    }
    public void BT06_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT06_1_", 0.2f);
        
    }
    public void BT06_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("BT06_2_", 0.2f);
        
    }

     void BT01_0_()
    {
        SceneManager.LoadScene("Stage01_1");
        LockOnOff.instance.GameCle = 1;
    }
     void BT01_1_()
    {
        SceneManager.LoadScene("Stage01_2");
        LockOnOff.instance.GameCle = 2;
    }
     void BT01_2_()
    {
        SceneManager.LoadScene("Stage01_3");
        LockOnOff.instance.GameCle = 3;
    }
     void BT01_3_()
    {
        SceneManager.LoadScene("Stage02_0");
        LockOnOff.instance.GameCle = 4;
    }
     void BT02_0_()
    {
        SceneManager.LoadScene("Stage02_1");
        LockOnOff.instance.GameCle = 5;
    }
     void BT02_1_()
    {
        SceneManager.LoadScene("Stage02_2");
        LockOnOff.instance.GameCle = 6;
    }
     void BT02_2_()
    {
        SceneManager.LoadScene("Stage02_3");
        LockOnOff.instance.GameCle = 7;
    }
     void BT02_3_()
    {
        SceneManager.LoadScene("Stage03_0");
        LockOnOff.instance.GameCle = 8;
    }
     void BT03_0_()
    {
        SceneManager.LoadScene("Stage03_1");
        LockOnOff.instance.GameCle = 9;
    }
     void BT03_1_()
    {
        SceneManager.LoadScene("Stage03_2");
        LockOnOff.instance.GameCle = 10;
    }
     void BT03_2_()
    {
        SceneManager.LoadScene("Stage03_3");
        LockOnOff.instance.GameCle = 11;
    }
     void BT03_3_()
    {
        SceneManager.LoadScene("Stage04_0");
        LockOnOff.instance.GameCle = 12;
    }
     void BT04_0_()
    {
        SceneManager.LoadScene("Stage04_1");
        LockOnOff.instance.GameCle = 13;
    }
     void BT04_1_()
    {
        SceneManager.LoadScene("Stage04_2");
        LockOnOff.instance.GameCle = 14;
    }
     void BT04_2_()
    {
        SceneManager.LoadScene("Stage04_3");
        LockOnOff.instance.GameCle = 15;
    }
     void BT04_3_()
    {
        SceneManager.LoadScene("Stage05_0");
        LockOnOff.instance.GameCle = 16;
    }
     void BT05_0_()
    {
        SceneManager.LoadScene("Stage05_1");
        LockOnOff.instance.GameCle = 17;
    }
     void BT05_1_()
    {
        SceneManager.LoadScene("Stage05_2");
        LockOnOff.instance.GameCle = 18;
    }
     void BT05_2_()
    {
        SceneManager.LoadScene("Stage05_3");
        LockOnOff.instance.GameCle = 19;
    }
     void BT05_3_()
    {
        SceneManager.LoadScene("Stage06_0");
        LockOnOff.instance.GameCle = 20;
    }
     void BT06_0_()
    {
        SceneManager.LoadScene("Stage06_1");
        LockOnOff.instance.GameCle = 21;
    }
     void BT06_1_()
    {
        SceneManager.LoadScene("Stage06_2");
        LockOnOff.instance.GameCle = 22;
    }
     void BT06_2_()
    {
        SceneManager.LoadScene("Stage06_3");
        LockOnOff.instance.GameCle = 23;
    }

    public void OutBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Out.SetActive(true);
    }
    public void NoOutBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Out.SetActive(false);
    }
    public void YesOutBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("YesOutBT_", 0.2f);
        //GameManager_1.instance.ClearCount = 0;
    }
    void YesOutBT_()
    {
        SceneManager.LoadScene("StageSelect");
        //GameManager_1.instance.ClearCount = 0;
    }
}
