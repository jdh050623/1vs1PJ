using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAni : MonoBehaviour //���� ��ư�� �������� ������ ���ϸ��̼�
{
    public GameObject Ani;
    public GameObject StartBT;
    public GameObject Title;
    public GameObject SelectBG;

    IEnumerator coru;

    bool StartBTClick = false;

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
    public void Update()
    {
        if(StartBTClick == true)
        {
            StartBT.SetActive(false);
            Title.SetActive(false);
            SelectBG.SetActive(true);
        }
    }
    public void StrartBT()
    {
        Ani.SetActive(true);
        StartBT.SetActive(false);
        Title.SetActive(false);
        SelectBG.SetActive(true);

        StartBTClick = true;
    }
}
