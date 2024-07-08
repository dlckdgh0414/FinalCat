using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Awake()
    {
        gameObject.SetActive(true);
        Playerpos = GameObject.Find("Player");
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Time.timeScale = 1;
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        UIManager.Instance._pool = false;
        Playerpos.transform.position = Vector2.zero;
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
        GameObject.FindGameObjectWithTag("Music5").GetComponent<BackGround5>().StopMusic();
        TextManager.Intance.isChoosing = false;
        GameManager.Instance.Menu.SetActive(true);
    }
    
    public void Exit()
    {
        Application.Quit();
        TextManager.Intance.isFreeze = true;
        TextManager.Intance.isChoosing = false;
    }
}
