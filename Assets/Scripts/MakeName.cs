using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeName : MonoBehaviour  //�̸������ �Լ�
{
    [SerializeField] private Text makeName;
    [SerializeField] private string saveName;
    public GameObject nameCanvus;
    //public string name;
    public void Name()
    {
        DataMgr.Instance.bringName = makeName.text;    //�Է��� �ؽ�Ʈ�� �����͸Ŵ����� ����
        print(DataMgr.Instance.bringName);
        //print(saveName.ToString());
        nameCanvus.SetActive(false); //����â ����
    }
}
