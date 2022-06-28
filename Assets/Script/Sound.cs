using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject SoundOff;

    public bool isMuted = false;

    public AudioSource BGM;

    public static Sound instance = null;


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

    public void SoundPlay(string SoundName,AudioClip clip)
    {
        GameObject go = new GameObject(SoundName + "Sound");
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        Destroy(go, clip.length);
    }

    public void SoundOnClick()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
        isMuted = true;
        AudioListener.pause = isMuted;
    }

    public void SoundOffClick()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        isMuted = false;
        AudioListener.pause = isMuted;
    }
}
