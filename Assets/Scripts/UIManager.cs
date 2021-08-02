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
    public void Jugar(){
         Time.timeScale=1;
        optionsPanel.SetActive(false);  
     
    }
    public void Menu(){
        SceneManager.LoadScene("Menu");
    }

    public void Configuracion(){
        SceneManager.LoadScene("Configuracion");
    }

    public void Salir(){
        //Application.Quit();
        SceneManager.LoadScene("Login");
    }

     public void Restart(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
