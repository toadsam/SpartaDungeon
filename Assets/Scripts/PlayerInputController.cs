using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;  //카메라는 메인 카메라
    }

    public void OnMove(InputValue value)  //매게 변수를 InputValue형태로 받기
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;  //움직이는 방향의 백테값 얻기
        CallMoveEvent(moveInput);   //CallMoveEvent(moveInput)실행
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();  //입력받은 벡터값
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);  //위치는 카메라 범위안의 백터 값을 넣기 월드 스페이스로 반환해줌
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