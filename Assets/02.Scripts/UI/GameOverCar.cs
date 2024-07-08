using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using KoreanTyper;

public class Endingdfajfafasf : MonoBehaviour
{
    public TextMeshProUGUI[] TestTexts;
    [SerializeField] GameObject[] Buttons;

    private void Start()
    {
        StartCoroutine(TypingText());
        Buttons[0].SetActive(false);
        Buttons[1].SetActive(false);
    }

    public IEnumerator TypingText()
    {
        while (true)
        {
            //=======================================================================================================
            // Initializing | �ʱ�ȭ
            //=======================================================================================================
            string[] strings = new string[4] { "GameOver", "����̰� ���� ġ�����ϴ�...", "����̸� ���� �������϶� �ǳ������ô�!!", "�ٽ� �ѹ� �� ��ȸ�� �ְڽ��ϴ�." };
            foreach (TextMeshProUGUI t in TestTexts)
                t.text = "";
            //=======================================================================================================


            //=======================================================================================================
            //  Typing effect | Ÿ���� ȿ��
            //=======================================================================================================
            for (int t = 0; t < TestTexts.Length && t < strings.Length; t++)
            {
                int strTypingLength = strings[t].GetTypingLength();

                for (int i = 0; i <= strTypingLength; i++)
                {
                    TestTexts[t].text = strings[t].Typing(i);
                    yield return new WaitForSeconds(0.03f);
                }
                // Wait 1 second per 1 sentence | �� ���帶�� 1�ʾ� ���
                yield return new WaitForSeconds(1f);
            }
            break;
        }
        Buttons[0].SetActive(true);
        Buttons[1].SetActive(true);
    }
}
