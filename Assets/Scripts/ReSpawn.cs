using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] cahrPrefabs;
    public GameObject player;
    void Start()
    {
        player = Instantiate(cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);
        player.transform.position = transform.position;
    }

    
}
