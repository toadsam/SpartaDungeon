using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Character    //����ü ĳ���� �����
{
    Player1, Player2, Player3, Player4

}
public class DataMgr : MonoBehaviour
{
    
    public string bringName;   
   public static DataMgr Instance;
    private void Awake()     //�̱��� ��ü�� �ϳ��� ����
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else if (Instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);  //���� �Ѿ�� �ı����� ����.
     
    }
    public  Character currentCharacter;   //����ĳ���� ����
}
