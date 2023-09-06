using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Character    //구조체 캐릭터 만들기
{
    Player1, Player2, Player3, Player4

}
public class DataMgr : MonoBehaviour
{
    
    public string bringName;   
   public static DataMgr Instance;
    private void Awake()     //싱글톤 객체를 하나만 만듬
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else if (Instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);  //씬이 넘어가도 파괴하지 않음.
     
    }
    public  Character currentCharacter;   //현재캐릭터 생성
}
