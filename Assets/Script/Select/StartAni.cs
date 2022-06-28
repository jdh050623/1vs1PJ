using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAni : MonoBehaviour //���� ��ư�� �������� ������ ���ϸ��̼�
{
    public GameObject BGM;
    public AudioClip Seaclip;

    public GameObject Ani;
    public GameObject SelectBG;
    public GameObject StartBG;

    IEnumerator coru;

    public bool StartBTClick = false;

    /* // �̱��� //
     * instance��� ������ static���� ������ �Ͽ� �ٸ� ������Ʈ ���� ��ũ��Ʈ������ instance�� �ҷ��� �� �ְ� �մϴ� 
     */
    public static StartAni instance = null;

    private void Awake()
    {
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ش�
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ��������
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
