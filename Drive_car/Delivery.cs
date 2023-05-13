using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // 물품을 가지고 있을 때 색 변환
    // new Color32(R,G,B,알파값);
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false; // 물건이 없다.

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    // start와 update와 같은 in built 메서드
    void OnCollisionEnter2D(Collision2D other) // Collision2D other : 충돌 시 관련 정보를 준다. 
    {
        // 출력
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // if (트리거한 것이 package면)
        // {
        //      "물품 픽업 됨" 이라고 출력할 것
        // }

        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            // 제거
            Destroy(other.gameObject, destroyDelay);
        }

        if(other.tag == "Customer" && hasPackage) // 태그가 손님이고, 물건이 있을때 (true일 떄,)
        {
            Debug.Log("Package Delivered");
            hasPackage = false; // 여러번 하는 꼼수를 방지.
            spriteRenderer.color = noPackageColor;
        }
    }
}
