using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class TextManager : MonoBehaviour
{
    [SerializeField] TalkManager talkManager;
    [SerializeField] GameObject talkPanel;
    [SerializeField] TextEffect TalkEffect;
    [SerializeField] GameObject scanObject;
    [SerializeField] GameObject ChoosePoolPath;
    [SerializeField] GameObject Choose;
    [SerializeField] GameObject YesOrNochoose;
    [SerializeField] GameObject CityUi;
    [SerializeField] GameObject reChoose;
    [SerializeField] GameObject Hille;
    [SerializeField] GameObject towne;
    [SerializeField] GameObject CityBack;
    [SerializeField] GameObject EndingJ;
    [SerializeField] GameObject Ending;
    [SerializeField] GameObject goI;
    [SerializeField] GameObject Reset;
    public bool isAction;
    [SerializeField] public bool isFreeze = true;
    public bool isChoosing { get; set; }
    public GameObject TalkPanel
    {
        get => talkPanel;
        set => talkPanel = value;
    }

    public static TextManager Intance;
    
    private void Start()
    {
        if (Intance == null)
        {
            Intance = this;
        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        NewMethod();
    }

    private void NewMethod()
    {
        isFreeze = true;
        Choose.SetActive(false);
        ChoosePoolPath.SetActive(false);
        YesOrNochoose.SetActive(false);
        CityUi.SetActive(false);
        reChoose.SetActive(false);
        CityBack.SetActive(false);
        EndingJ.SetActive(false);
        Ending.SetActive(false);
        goI.SetActive(false);
        Reset.SetActive(false);
    }

    public int talkIndex;

    public void Action(GameObject scanObj)
    {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC,objData.isChoose, objData.isPos,objData.isYesNo,objData.isClity, objData.isReChoose,objData.isHille,objData.isTown,objData.isCityBack,objData.isEndingjunction,objData.isEnding,objData.isNextHouse,objData.isBack);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC, bool isChoose, bool isPos, bool isYesNo, bool isClity, bool isReChoose, bool isHille, bool isTown, bool isCityBack,bool isEndingjunction, bool isEnding, bool isNextHouse, bool isBack)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            if (isChoose)
            {
                isAction = true;    
                isFreeze = false;
                Debug.Log(isFreeze);
                Choose.SetActive(true);
                isChoosing = true;
            }
            if(isPos)
            {
                isAction = true;
                isFreeze = false;
                ChoosePoolPath.SetActive(true);
                isChoosing = true;
            }
            if (isYesNo)
            {
                isAction = true;
                isFreeze = false;
                YesOrNochoose.SetActive(true);
                isChoosing = true;
            }
            if(isClity)
            {
                isAction = true;
                isFreeze = false;
                CityUi.SetActive(true);
                isChoosing = true;
            }  
            if(isReChoose)
            {
                isAction = true;
                isFreeze = false;
                reChoose.SetActive(true);
                isChoosing = true;
            } 
            if(isHille)
            {
                isAction = true;
                isFreeze = false;
                Hille.SetActive(true);
                isChoosing = true;
            } 
            if(isTown)
            {
                isAction = true;
                isFreeze = false;
                towne.SetActive(true);
                isChoosing = true;
            }
            if(isCityBack)
            {
                isAction = true;
                isFreeze = false;
                CityBack.SetActive(true);
                isChoosing = true;
            }
            if(isEndingjunction)
            {
                isAction = true;
                isFreeze = false;
                EndingJ.SetActive(true);
                isChoosing = true;
            } 
            if(isEnding)
            {
                isAction = true;
                Ending.SetActive(true);
                isFreeze = false;
                isChoosing = true;
            }
            if(isNextHouse)
            {
                isAction = true;
                isFreeze = false;
                goI.SetActive(true);
                isChoosing = true;
            }
            if(isBack)
            {
                isAction = true;
                isFreeze = false;
                Reset.SetActive(true);
                isChoosing = true;
            }

            talkIndex = 0; //��ȭ�� ���� �� 0���� �ʱ�ȭ , �ٸ� �繰�ϰ� ��� ��ȭ�� ���� �ϱ� ����.
            isFreeze = true;
            isAction = false;
            return;  // �� , void �Լ����� return�� ���� ���� ����.
        }
        if (isNPC)
        {
            TalkEffect.SetMsg(talkData.Split(':')[0]);
        }

        else
        {
            TalkEffect.SetMsg(talkData);
        }
        isFreeze = false;
        talkIndex++;
    }
}
