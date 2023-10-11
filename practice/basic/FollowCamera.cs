using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 카메라 이동
    public GameObject target; // 메인 카메라가 아닌 다른 오브젝트를 들고 오는 것이기 때문에 사용
    // 나중에 target은 인스펙터에서 지정.
    private void LateUpdate() {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        // position 이동 target의 x값과 y값에 따라 카메라를 이동시킨다. z축과 겹치면 안되기 때문에 z값은 맨 앞쪽으로 당긴다. 
    }    
}
