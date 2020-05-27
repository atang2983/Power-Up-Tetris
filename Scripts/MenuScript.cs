using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("TetrisScene");
    }

    public void helpMenu(){
      SceneManager.LoadScene("HelpScene");
    }

    public void optionsScene(){
      SceneManager.LoadScene("OptionsScene");
    }

    public void backButton(){
      SceneManager.LoadScene("MenuUI");
    }

    public void quitGame(){
      Application.Quit();
    }
}
