using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // public Transform player;
    //public GameObject player;
    public ReSpawn reSpawn;
    // Start is called before the first frame update
    void LateStart()
    {
      // player = reSpawn.player;  
        // player = Instantiate(reSpawn.cahrPrefabs[(int)DataMgr.Instance.currentCharacter]);
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // Debug.Log(player);
        transform.position = Vector3.Lerp(transform.position, reSpawn.player.transform.position, Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
