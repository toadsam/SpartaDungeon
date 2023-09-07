using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;  //ī�޶�� ���� ī�޶�
    }

    public void OnMove(InputValue value)  //�Ű� ������ InputValue���·� �ޱ�
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;  //�����̴� ������ ���װ� ���
        CallMoveEvent(moveInput);   //CallMoveEvent(moveInput)����
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();  //�Է¹��� ���Ͱ�
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);  //��ġ�� ī�޶� �������� ���� ���� �ֱ� ���� �����̽��� ��ȯ����
        newAim = (worldPos - (Vector2)transform.position).normalized;  

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
}