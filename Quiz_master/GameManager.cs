using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 유니티 엔진 자체의 신 메니지먼트를 이용

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    endScreen endscreen;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endscreen = FindObjectOfType<endScreen>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true); // 계층에서 퀴즈 오브젝트를 활성화
        endscreen.gameObject.SetActive(false); // 계층에서 끝나는 오브젝트를 비활성화
    }

    
    void Update()
    {
        if(quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endscreen.gameObject.SetActive(true);
            endscreen.ShowFinalScore(); // 최종 점수 표시하는 텍스트 갱신
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // 신 메니저에서 활성화된 신의 buildIndex를 들고 오는 것.
    }
}
