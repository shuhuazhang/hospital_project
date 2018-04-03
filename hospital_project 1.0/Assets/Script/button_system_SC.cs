using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button_system_SC : MonoBehaviour {

    public GameObject START_B, DOCTOR_B, HISTORY_B, LEFT_B, MUSIC_B;

    public void START_B_click()
    {
        Debug.Log("START_B_click succed");
        SceneManager.LoadScene("SECOND");
    }
    public void DOCTOR_B_click()
    {
        Debug.Log("DOCTOR_B_click succed");
        SceneManager.LoadScene("DOCTOR");
    }
    public void HISTORY_B_click()
    {
        Debug.Log("HISTORY_B_click succed");
        SceneManager.LoadScene("HISTORY");
    }
    public void LEFT_B_click()
    {
        Debug.Log("LEFT_B_click succed");
        Application.Quit();
    }
    public void MUSIC_B_click()
    {
        Debug.Log("MUSIC_B_click succed");
        //音乐模块暂时未完成
    }
}
