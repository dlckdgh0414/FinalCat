using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using KoreanTyper;

public class Ending : MonoBehaviour
{
    public TextMeshProUGUI[] TestTexts;
    [SerializeField] GameObject Buttons;

    private void Start()
    {
        StartCoroutine(TypingText());
        Buttons.SetActive(false);
    }

    public IEnumerator TypingText()
    {
        while (true)
        {
            //=======================================================================================================
            // Initializing | �ʱ�ȭ
            //=======================================================================================================
            string[] strings = new string[4] { "Ending1", "� �ҳడ �ڽ��ȿ� �ִ� ����̸� �߰��� ������ ��������ϴ�.","����̴� �ҳ࿡ ������ �ູ�ϰ� �����°Ű����ϵ�.","����̰� ��� �������� �ѹ� ���������?" };
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
        Buttons.SetActive(true);
    }
}
