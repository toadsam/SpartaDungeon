using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] cahrPrefabs;  //캐릭터 프리팹
    public GameObject player;
    void Start()
    {
        
        player = Instantiate(cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);  //캐릭터를 생성하는데 캐리터 프리팹에 있는 배열을 가져와서 소환)
        
        player.transform.position = transform.position;  //초기위치 선정
        
    }

    
}
