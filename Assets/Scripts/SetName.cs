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
        nameTxt.text = DataMgr.Instance.bringName;  //데이터 매니저를 통해 전달
        print(nameTxt.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
