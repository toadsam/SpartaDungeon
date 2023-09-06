using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeName : MonoBehaviour  //이름만드는 함수
{
    [SerializeField] private Text makeName;
    [SerializeField] private string saveName;
    public GameObject nameCanvus;
    //public string name;
    public void Name()
    {
        DataMgr.Instance.bringName = makeName.text;    //입력한 텍스트를 데이터매니저에 저장
        print(DataMgr.Instance.bringName);
        //print(saveName.ToString());
        nameCanvus.SetActive(false); //상태창 끄기
    }
}
