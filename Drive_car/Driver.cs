using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   // 변수 지정
   [SerializeField]float steerSpeed = 1f; // 회전 변수
   // SerializeField : inspector에 표시되게 만들어준다. 
   // VSC에서 바꾸지 않아도 바꿀 수 있음. 
   [SerializeField]float moveSpeed = 20f; // 직진 변수
   [SerializeField]float slowSpeed = 10f;
   [SerializeField]float boostSpeed = 30f;


    void Update() // 각 초마다 실행되는 메서드
    {
        // Input : 동작을 컴퓨터가 알 수 있게 만드는 함수
        // Axis : 어떤 좌표에서 부터 좌표까지의 거리
        // -1: 왼쪽  0: 중간  1: 오른쪽
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // 속도 추가
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Time.deltaTime : 1 프레임 당 걸리는 시간. 
        // 1 유닛을 하는 데 컴퓨터의 성능 차이 없이 같게 만들어 준다. 

        transform.Rotate(0,0,-steerAmount); // transform : 변환, rotate : 회전
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost") 
        {
            moveSpeed = boostSpeed;
        }   
    }
}
