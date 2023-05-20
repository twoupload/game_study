using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f; // 문제를 푸는 시간.
    [SerializeField] float timeToShowCorrectAnswer = 10f; // 정답을 검토하는 시간.
    
    public bool loadNextQuestion;

    // 타이머 제어하는 메서드. 퀴즈 스크립트가 들고 올 수 있어야 함.
    public float fillFraction; // 0~1까지 중 타이머 fraction

    // 퀴즈 스크립트가 들고 올 수 있어야 함으로 public, 게더 메서드도 가능.
    public bool isAnsweringQuestion;

    float timerValue; // 타이머 값
    void Update()
    {
        UpdateTimer(); // 타이머를 구현 시작
    }

   // 정답을 맞췄을 때, 시간을 바로 넘길 수 있는 메서드.
    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime; // 타이머 값이 게임 프레임마다 줄어듬.
        
        if(isAnsweringQuestion) 
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false; // 스위치 false
                timerValue = timeToShowCorrectAnswer; // 타이머 초기화.
            }
            
        }

        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true; // 스위치 true
                timerValue = timeToCompleteQuestion; // 타이머 초기화.
                loadNextQuestion = true;
            }
        }
        Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
