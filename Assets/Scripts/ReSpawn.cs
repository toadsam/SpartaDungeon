using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] cahrPrefabs;  //ĳ���� ������
    public GameObject player;
    void Start()
    {
        
        player = Instantiate(cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);  //ĳ���͸� �����ϴµ� ĳ���� �����տ� �ִ� �迭�� �����ͼ� ��ȯ)
        
        player.transform.position = transform.position;  //�ʱ���ġ ����
        
    }

    
}
