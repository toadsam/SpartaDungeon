using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectchar : MonoBehaviour
{
    public Character character;  //ĳ���� ���� -> ĳ���Ϳ� �̽�ũ��Ʈ�� ���̰�  

    private void Start()
    {
        
    }

    private void OnMouseUpAsButton()  //���콺�� ������ �ߵ��ϴ� �Լ�
    {
        DataMgr.Instance.currentCharacter = character;  // ������ ĳ���͸� ������ �Ŵ������� ����
    }

}
