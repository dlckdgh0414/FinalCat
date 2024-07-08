using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    //[SerializeField] private TextDataListSO textDataListSO;
     public Dictionary<int, string[]> talkData;

    public static TalkManager Inatnce;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        if (Inatnce == null)
        {
            Inatnce = this;
        }
        else
            Destroy(gameObject);

        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(0, new string[] { "���� ��ġ��" });
        talkData.Add(1, new string[] { "��û ū ���̴�.", "�������� ������ �� ���� �� ����.", "�ƽ��� ��" });
        talkData.Add(2, new string[] { "����̰� ���ְ� �԰� ���� �� �����̴�.", "����̴� �谡 �θ��Ű���.", "���� ���� ����?" });
        talkData.Add(3, new string[] { "����̴� ���� �谡 �ſ� ���°Ű���.", "�������� ����Ⱑ �����Ű���.", "�츮�� ����̸� ���� ����⸦ ����ٱ��?" });
        talkData.Add(4, new string[] { "������ ���� �������ڿ� ���ô밡 �ִ�.", "�� ������ ����Ⱑ ������ �����Ű���.", });
        talkData.Add(5, new string[] { "����̰� �谡 ������ �񸻶��մϴ�.", "��ħ �������� �ֳ׿�", "ǥ���ǿ��� �������� ��å�ζ�� �����ֽ��ϴ�.", "���� ���°� �������?" });
        talkData.Add(6, new string[] { "����̴� ���� �踦 ä���� ���߽��ϴ�. �׷��� ���ư��� �ǰ���?" });
        talkData.Add(7, new string[] { "�ٽ� ���ư��ǰǰ���?" });
        talkData.Add(8, new string[] { "ǥ���ǿ� ���÷� �������±��̶� �����ִ�", "���÷� ����������?", "*���� �������� ����̿��� ���� ����ٸ� �����Ҽ����ֽ��ϴ�.", "���� ��ٸ� ���÷� �����������?" });
        talkData.Add(9, new string[] { "�赵 ä������ ���� ��å�η� ����������?" });
        talkData.Add(10, new string[] { "�տ� Ⱦ�ܺ����� �ִ�.", "�������϶� �������� �����ϰ���?" });
        talkData.Add(11, new string[] { "���Ǳ��.", "������ ���� �׸��� ���� �����ѰŰ���.", "����̸� �ƴϿ��� �̾� �Ծ���." });
        talkData.Add(12, new string[] { "�Ϲ� ���������̴�.", "���������� �������� �и����Ż����̳���." });
        talkData.Add(13, new string[] { "��Ȱ�� ���������̴�", "��Ȱ�� �������뿡 �Ϲݾ����⵵ �� ����ִ°Ű���.", "��Ȱ��������.." });
        talkData.Add(14, new string[] { "�ٽ� ��å�η� ���ư��ǰ���?", "���ư��� �ٽ� �Ϸ� �;��մϴ�..." });
        talkData.Add(15, new string[] { "�����������̴� ���ڿ� �����Ⱑ �������ֳ׿�.", "������ ���� ����� �ʴ°Ű��׿�.." });
        talkData.Add(16, new string[] { "��ȭ���̴�." });
        talkData.Add(17, new string[] { "�����̴�.", "�̰� ���峪�� �������� �ʴ°Ű���.." });
        talkData.Add(18, new string[] { "�����Ա��� �����ִ� ǥ�����̴�.", "���� ���� �Ա��� ���� �����Ű���. ������?" });
        talkData.Add(19, new string[] { "��å�ΰ��±��̶�� �����ִ� ǥ�����̴�.", "�ٽ� ��å�ΰ��±�� ���ư���?" });
        talkData.Add(20, new string[] { "�ڽ���.", "�ڽ��� ���� �ȿ� ����ʹ�..", "������?" });
        talkData.Add(21, new string[] { "�ٷ� �տ� �ް���� �ִ°Ű���.", "�ް������ ������?" });
        talkData.Add(22, new string[] { "���� ��¦ �����ִ°Ű���.","�ѹ� ��������?" });
        talkData.Add(23, new string[] { "���Ĺ� �����Ⱑ ���� �������ִ�..","������ �����Գ���.","����.." });
        talkData.Add(24, new string[] { "����� ���� ����սô�!","���� ���ϴ��� �������ϴ�..","�ٽ� ó�������ؼ� �ٸ������� �����?" });
        talkData.Add(25, new string[] { "�ڰ��ִ°Ű���..","���� �� ������ٵ�..","��ư �츮 ������." });
        talkData.Add(26, new string[] { "����� ���̱���","���� �� ������״� ��ٸ����ְڽ��ϴ�."});
        talkData.Add(27, new string[] { "�ҳ�: �� �����!! ����� �Ϸο�!!","���ο��� �ȱ�� ����̴� �ູ�ϰ� �����°Ű�����.","�ٽ� ó������ �ٸ������������?"});
        talkData.Add(28, new string[] { "����ö �����ֳ׿�.","���� �����ö� ���� ���迪�� �������׿�.","����� ���� �Ⱦ�.","����ö�� ������ʴ°Ű��׿�."});
        talkData.Add(29, new string[] { "����̰� �Դ� �� �׸������ϴ�.", "������ִ°ź��� �̹� ���� �����Ű����ϴ�." });        
    }


    //public string GetTalk(int id, int talkIndex)
    //{
    //    Debug.Log(talkIndex);
    //    Debug.Log(textDataListSO.list[id].text.Count);
    //    if (talkIndex <= textDataListSO.list.Count)
    //    {
    //        return textDataListSO.list[id].text[talkIndex];
    //    }
    //    return "NULL";
    //}

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
        { 
            return talkData[id][talkIndex];
        }

    }

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
    }
}
