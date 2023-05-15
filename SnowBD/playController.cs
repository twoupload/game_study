using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playController : MonoBehaviour
{
    [SerializeField]float torqueAmount = 1f; // 회전하는 정도
    [SerializeField]float boostSpeed = 30f;
    [SerializeField]float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    bool canMove = true;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); // 특정 컴포넌트에 import
       surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>(); // Type에 접근할 수 있도록 하는 것. 
    }

    // Update is called once per frame
    void Update()
    { 
        if(canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }

            
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }

        else{
            surfaceEffector2D.speed = baseSpeed;
        }
        // 위쪽 방향키 속도 증가
        // 다른 방향키는 속도 보통.
        // surface Effector 2d에 접근해서 속도를 바꿔야 한다. 
    }

    void RotatePlayer()
    {

        // Getkey = 키보드를 누를 때.
        // Keycode = 키를 누를 때의 동작 지정
        if (Input.GetKey(KeyCode.LeftArrow))
        { // 왼쪽으로 회전
            rb2d.AddTorque(torqueAmount); // 회전시키는 명령어
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        { // 오른쪽으로 회전
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
