using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // public Transform player;
    public GameObject player;
    public ReSpawn reSpawn;
    // Start is called before the first frame update
    void Start()
    {
       
      // player = Instantiate(reSpawn.cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        player = reSpawn.player;
        transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
