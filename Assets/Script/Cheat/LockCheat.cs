using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCheat : MonoBehaviour
{
    bool Che = false;

    public static LockCheat instance = null;

    private void Awake()
    {
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }
    }

    public void Update()
    {

        if (Che == true)
        {
            LockOnOff.instance.GameCle = 24;
        }
    }
    public void CheatBT()
    {
        LockOnOff.instance.GameCle = 24;
        Che = true;

    }
}
