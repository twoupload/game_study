using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   // 카메라의 위치는 차량의 위치와 같게 한다.

   // 유니티 창에 띄우게 한다. 
   [SerializeField] GameObject thingToFollow; // 카메라의 오브젝트. 원 래 오브젝트를 드러낸다.

    
    void LateUpdate()
    {
        // 위치 표시 = 원래 위치에서, 0,0,-10 더함.(new vector 3)
        // ref를 시켜준다. 
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10); 
    }
}
