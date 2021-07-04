using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeleccionEscenario : MonoBehaviour
{
    public void GoMachuPicchu(){
        SceneManager.LoadScene("MachuPicchu_01");
    }

    public void GoMurallaChina(){
        SceneManager.LoadScene("MurallaChina_01_0111111111111111111111111");
    }

    public void GoChichenItza(){
        SceneManager.LoadScene("ChichenItza_01");
    }
}
