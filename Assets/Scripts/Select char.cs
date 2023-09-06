using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectchar : MonoBehaviour
{
    public Character character;  //캐릭터 선택 -> 캐릭터에 이스크립트를 붙이고  

    private void Start()
    {
        
    }

    private void OnMouseUpAsButton()  //마우스를 누르면 발동하는 함수
    {
        DataMgr.Instance.currentCharacter = character;  // 누르면 캐릭터를 데이터 매니저한테 저장
    }

}
