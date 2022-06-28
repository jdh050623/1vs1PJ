using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Select_ : MonoBehaviour // 스타트와 스테이지 선택창 버튼에 관련된 스크립트이다.
{
    public AudioClip BTclip;

    [Header("스테이지 선택 구역")]
    public GameObject ForestBG;
    public GameObject MountainBG;
    public GameObject BeachBG;
    public GameObject NorthPoleBG;
    public GameObject DesertBG;
    public GameObject AntarcticaBG;

    [Header("인게임에서 뒤로 왔을때 사라져야 하는 것")]
    public GameObject StartBG;
    private void Update()
    {
        
        if (StartAni.instance.StartBTClick == true)
        {
            StartBG.SetActive(false);
            
        }
    }

    //스테이지 테마 선택
    public void ForestBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        ForestBG.SetActive(true);
    }
    public void MountainBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        MountainBG.SetActive(true);
    }
    public void BeachBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        BeachBG.SetActive(true);
    }
    public void NorthPoleBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        NorthPoleBG.SetActive(true);
    }
    public void DesertBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        DesertBG.SetActive(true);
    }
    public void AntarcticaBT()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        AntarcticaBG.SetActive(true);
    }

    //스테이지 테마 나가기
    public void SelOut()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        ForestBG.SetActive(false);
        MountainBG.SetActive(false);
        BeachBG.SetActive(false);
        NorthPoleBG.SetActive(false);
        DesertBG.SetActive(false);
        AntarcticaBG.SetActive(false);
    }

    //스테이지 이동
    public void Stage01_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage01_0_", 0.2f);
        
    }
    public void Stage02_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage02_0_", 0.2f);
    }
    public void Stage03_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage03_0_", 0.2f);
    }
    public void Stage04_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage04_0_", 0.2f);
    }
    public void Stage05_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage05_0_", 0.2f);
    }
    public void Stage06_0()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage06_0_", 0.2f);
    }
    public void Stage01_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage01_1_", 0.2f);
    }
    public void Stage02_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage02_1_", 0.2f);
    }
    public void Stage03_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage03_1_", 0.2f);
    }
    public void Stage04_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage04_1_", 0.2f);
    }
    public void Stage05_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage05_1_", 0.2f);
    }
    public void Stage06_1()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage06_1_", 0.2f);
    }
    public void Stage01_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage01_2_", 0.2f);
    }
    public void Stage02_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage02_2_", 0.2f);
    }
    public void Stage03_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage03_2_", 0.2f);
    }
    public void Stage04_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage04_2_", 0.2f);
    }
    public void Stage05_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage05_2_", 0.2f);
    }
    public void Stage06_2()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage06_2_", 0.2f);
    }
    public void Stage01_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage01_3_", 0.2f);
    }
    public void Stage02_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage02_3_", 0.2f);
    }
    public void Stage03_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage03_3_", 0.2f);
    }
    public void Stage04_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage04_3_", 0.2f);
    }
    public void Stage05_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage05_3_", 0.2f);
    }
    public void Stage06_3()
    {
        Sound.instance.SoundPlay("Credit", BTclip);
        Invoke("Stage06_3_", 0.2f);
    }

    //스테이지 이동 함수
    void Stage01_0_()
    {    
        SceneManager.LoadScene("Stage01_0");
    }
    void Stage02_0_()
    {    
        SceneManager.LoadScene("Stage02_0");
    }
    void Stage03_0_()
    {     
        SceneManager.LoadScene("Stage03_0");
    }
    void Stage04_0_()
    {     
        SceneManager.LoadScene("Stage04_0");
    }
    void Stage05_0_()
    {        
        SceneManager.LoadScene("Stage05_0");
    }
    void Stage06_0_()
    {        
        SceneManager.LoadScene("Stage06_0");
    }
    void Stage01_1_()
    {       
        SceneManager.LoadScene("Stage01_1");
    }
    void Stage02_1_()
    { 
        SceneManager.LoadScene("Stage02_1");
    }
    void Stage03_1_()
    {       
        SceneManager.LoadScene("Stage03_1");
    }
    void Stage04_1_()
    {    
        SceneManager.LoadScene("Stage04_1");
    }
    void Stage05_1_()
    {      
        SceneManager.LoadScene("Stage05_1");
    }
    void Stage06_1_()
    {      
        SceneManager.LoadScene("Stage06_1");
    }
    void Stage01_2_()
    {        
        SceneManager.LoadScene("Stage01_2");
    }
    void Stage02_2_()
    {       
        SceneManager.LoadScene("Stage02_2");
    }
     void Stage03_2_()
    {        
        SceneManager.LoadScene("Stage03_2");
    }
     void Stage04_2_()
    {     
        SceneManager.LoadScene("Stage04_2");
    }
     void Stage05_2_()
    {      
        SceneManager.LoadScene("Stage05_2");
    }
     void Stage06_2_()
    {       
        SceneManager.LoadScene("Stage06_2");
    }
     void Stage01_3_()
    { 
        SceneManager.LoadScene("Stage01_3");
    }
     void Stage02_3_()
    {        
        SceneManager.LoadScene("Stage02_3");
    }
     void Stage03_3_()
    {         
        SceneManager.LoadScene("Stage03_3");
    }
     void Stage04_3_()
    {     
        SceneManager.LoadScene("Stage04_3");
    }
    void Stage05_3_()
    {       
        SceneManager.LoadScene("Stage05_3");
    }
    void Stage06_3_()
    {
        SceneManager.LoadScene("Stage06_3");
    }

}
