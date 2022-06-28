using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAni : MonoBehaviour //시작 버튼을 눌렀을때 나오는 에니메이션
{
    public GameObject BGM;
    public AudioClip Seaclip;

    public GameObject Ani;
    public GameObject SelectBG;
    public GameObject StartBG;

    IEnumerator coru;

    public bool StartBTClick = false;

    /* // 싱글톤 //
     * instance라는 변수를 static으로 선언을 하여 다른 오브젝트 안의 스크립트에서도 instance를 불러올 수 있게 합니다 
     */
    public static StartAni instance = null;

    private void Awake()
    {
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어준다
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제해줌
        }
    }
    public void StartBTGO()
    {
        BGM.SetActive(false);
        Sound.instance.SoundPlay("Credit", Seaclip);
        coru = StartAniGO();
        Ani.SetActive(true);
        StartCoroutine(coru);

    }

    IEnumerator StartAniGO()
    {
        yield return new WaitForSeconds(2.2f);
        StartBG.SetActive(false);
        StartBTClick = true;
        yield return new WaitForSeconds(0.5f);
        Ani.SetActive(false);
        BGM.SetActive(true);
        StopCoroutine(coru);
    }
}
