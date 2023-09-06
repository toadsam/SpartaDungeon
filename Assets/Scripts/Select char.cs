using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectchar : MonoBehaviour
{
    public Character character;

    private void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        DataMgr.Instance.currentCharacter = character;
    }

}
