using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerN_0 : MonoBehaviour //�ٸ� ��ũ��Ʈ�� �ʿ��� ���� �����ִ� ��ũ��Ʈ 
{
    public static GameManagerN_0 instance = null; //������ GameManagerN_0(Ŭ���� �̸�).instance(������ �̸�).n_0Clear(�� �Լ�,����)
    public GameObject GameClear_0;

    public bool Second;

    public int Clear = 0;//Ŭ���� �ߴ��� Ȯ���� �ش�.
    private void Awake()
    {
        Second = false;
        Clear = 0;
        instance = this; //���ڽ��� instance�� �־��ݴϴ�.
    }
    private void Update()
    {
        if (Clear == 2)
        {
            GameClear_0.SetActive(true);
            Clear = 0;
        }
    }
}
