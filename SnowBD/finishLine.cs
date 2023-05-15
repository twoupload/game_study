using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    [SerializeField] float reloadAmount = 0.5f;
    [SerializeField] ParticleSystem finishEffect; // 입자 효과 reference
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            finishEffect.Play(); // 입자 시작.
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",reloadAmount);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
