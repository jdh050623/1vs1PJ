using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_2 : MonoBehaviour //스테이지 스폰 스크립트
{
    public List<GameObject> Animal;
    public List<GameObject> WrongAnimal;
    
    public List<Transform> SpawnPoints;
    
    int randAG;//동물 게임 오브젝트 랜덤
    int randWG;// 틀린 동물  게임 오브젝트랜덤
    int randST1;// 스폰 트렌스폼 랜덤
    //int randST2;// 스폰 트렌스폼 랜덤
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            randWG = Random.Range(0, WrongAnimal.Count);
            randST1 = Random.Range(0, SpawnPoints.Count);
            Instantiate(WrongAnimal[randWG], SpawnPoints[randST1].position, SpawnPoints[randST1].rotation, GameObject.Find("Canvas/OBGGroup").transform);
            WrongAnimal.RemoveAt(randWG);//리스트 삭제  
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
