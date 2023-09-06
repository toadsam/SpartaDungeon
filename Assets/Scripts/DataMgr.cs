using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Player1, Player2, Player3, Player4

}
public class DataMgr : MonoBehaviour
{
   public static DataMgr Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else if (Instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
     
    }
    public  Character currentCharacter;  
}
