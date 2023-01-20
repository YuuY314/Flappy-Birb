using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene(1);
    }

    public void quitGame(){
        Application.Quit();
    }
}
