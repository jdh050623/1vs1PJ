using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_2 : MonoBehaviour //�������� ���� ��ũ��Ʈ
{
    public List<GameObject> Animal;
    public List<GameObject> WrongAnimal;
    
    public List<Transform> SpawnPoints;
    
    int randAG;//���� ���� ������Ʈ ����
    int randWG;// Ʋ�� ����  ���� ������Ʈ����
    int randST1;// ���� Ʈ������ ����
    //int randST2;// ���� Ʈ������ ����
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            randWG = Random.Range(0, WrongAnimal.Count);
            randST1 = Random.Range(0, SpawnPoints.Count);
            Instantiate(WrongAnimal[randWG], SpawnPoints[randST1].position, SpawnPoints[randST1].rotation, GameObject.Find("Canvas/OBGGroup").transform);
            WrongAnimal.RemoveAt(randWG);//����Ʈ ����  
            SpawnPoints.RemoveAt(randST1);

        }
        for (int i = 0; i < 2; i++)
        {
            randAG = Random.Range(0, Animal.Count);
            randST1 = Random.Range(0, SpawnPoints.Count);
            Instantiate(Animal[randAG], SpawnPoints[randST1].position, SpawnPoints[randST1].rotation, GameObject.Find("Canvas/OBGGroup").transform);
            Animal.RemoveAt(randAG);
            SpawnPoints.RemoveAt(randST1);
        }
    }
}
