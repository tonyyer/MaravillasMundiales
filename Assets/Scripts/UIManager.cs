using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;

    void Start()
    {
        Time.timeScale=1;
        if(SceneManager.GetActiveScene().buildIndex == 0){
           Time.timeScale=0;

        }
        
    } 

    public void OptionsPanel(){
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    }
    public void Return(){
         Time.timeScale=1;
        optionsPanel.SetActive(false);       
    }
    public void AnotherOptions(){
        SceneManager.LoadScene("Niveles");
    }

    public void GoMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void GoMainNiveles(){
        SceneManager.LoadScene("Niveles");
    }

    public void Retornar(){
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame(){
        //Application.Quit();
        SceneManager.LoadScene("EmailAuth");
    }

 

}
