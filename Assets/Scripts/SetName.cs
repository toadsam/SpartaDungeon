using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    [SerializeField] private Text nameTxt;
    // Start is called before the first frame update
    void Start()
    {
        nameTxt.text = DataMgr.Instance.bringName;  //������ �Ŵ����� ���� ����
        print(nameTxt.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
