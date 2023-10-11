using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover_Other : MonoBehaviour
{
    Rigidbody2D rb; // 리지드바디를 위한 변수 지정
    float speed = 100f; // 스피드를 지정. 실수이므로 f 붙음.

    void Start() // 시작할 때, 해당 함수 실행
    {
        // 관련 오브젝트의 Rigidbody2d 컴포넌트를 불러오는 것을 의미.
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if((Input.GetKey(KeyCode.LeftArrow)) == true) // 왼족 키를 누르고 있을때.
        {
            // 리지드바디는 AddForce라는 것이 존재. 이건 물리적인 힘을 가하는 명령어.
            rb.AddForce(Vector3.left * speed * Time.deltaTime); // 이동
        }

        if((Input.GetKey(KeyCode.RightArrow)) == true) // 오른쪽
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        if((Input.GetKey(KeyCode.UpArrow)) == true) // 위쪽 키
        {
            rb.AddForce(Vector3.up * speed * Time.deltaTime);
        }

        if((Input.GetKey(KeyCode.DownArrow)) == true) // 아래쪽 키
        {
            rb.AddForce(Vector3.down * speed * Time.deltaTime);
        }
    }
}
 