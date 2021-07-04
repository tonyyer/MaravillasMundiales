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
        SceneManager.LoadScene("MurallaChina_01");
    }
}
