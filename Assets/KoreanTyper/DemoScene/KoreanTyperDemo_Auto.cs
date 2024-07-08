﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;                                                  // Add KoreanTyper namespace | 네임 스페이스 추가
using TMPro;

//===================================================================================================================
//  Auto Demo
//  자동으로 글자가 입력되는 데모
//===================================================================================================================
public class KoreanTyperDemo_Auto : MonoBehaviour {
    public TextMeshProUGUI[] TestTexts;
    [SerializeField] GameObject[] Buttons;

    private void Start() {
        StartCoroutine(TypingText());
        Buttons[0].SetActive(false);
        Buttons[1].SetActive(false);
    }

    public IEnumerator TypingText() {
        while (true) {
            //=======================================================================================================
            // Initializing | 초기화
            //=======================================================================================================
            string[] strings = new string[4] { "GameOver","고양이가 배가고파 더 이상 움직일 힘이없습니다...","고양이가 배고파하는데 무시하는 이 악마!","다시 한번 더 기회를 주겠습니다." };
            foreach (TextMeshProUGUI t in TestTexts)
                t.text = "";
            //=======================================================================================================


            //=======================================================================================================
            //  Typing effect | 타이핑 효과
            //=======================================================================================================
            for (int t = 0; t < TestTexts.Length && t < strings.Length; t++) {
                int strTypingLength = strings[t].GetTypingLength();

                for (int i = 0; i <= strTypingLength; i++) {
                    TestTexts[t].text = strings[t].Typing(i);
                    yield return new WaitForSeconds(0.03f);
                }
                // Wait 1 second per 1 sentence | 한 문장마다 1초씩 대기
                yield return new WaitForSeconds(1f);
            }
            break;
        }
        Buttons[0].SetActive(true);
        Buttons[1].SetActive(true);
    }
}

