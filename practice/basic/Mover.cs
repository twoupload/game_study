using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] // 인스펙터에 해당 값을 직접 조절할 수 있도록 만든다. 
    float moveSpeed = 5f; // 실수 변수를 지정할 때는 f를 숫자 뒤에 붙여서 나타낸다. 


    // Update() : 매 프레임마다 호출
    // LateUpdate() : 모든 Update 함수가 호출된 후 마지막에 호출 - 오브젝트를 따라가는 카메라 등에 주로 사용.
    private void FixedUpdate() { // 설정된 값에 따라 일정한 간격으로 호출된다. 
        Move(); // 일정한 간격으로 Mover 호출
    }

    private void Move() {

        // 키보드 키 입력에 따른 좌우 이동
        if(Input.GetAxis("Horizontal") > 0) // 키보드 키를 입력받는 것 : input.GetAxis, 좌우 관련 : Horizontal, 양수 : 오른쪽
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0); // Time.deltaTime을 통해 컴퓨터 성능에 상관없이 시간을 고르게 분배
        }
        else if(Input.GetAxis("Horizontal") < 0) // 음수 : 왼쪽 이동
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime; 
            // Vector3을 사용해야 함. Vector2(x,y)는 2D이지만 존재하는 z축을 반영하지 못하기 때문
        }
        
        // 다른 방법으로 표현
        // 키보드 키 입력에 따른 위 아래 이동
        if(Input.GetKey(KeyCode.UpArrow)) // 키보드에 따른 위 아래 이동
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime; // z값은 생략
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        }


    }
}
