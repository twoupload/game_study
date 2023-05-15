using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{
    [SerializeField] float reloadAmount = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) {

        
        if(other.tag == "Ground" && !hasCrashed)
        {

            hasCrashed = true;
            FindObjectOfType<playController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadAmount);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
