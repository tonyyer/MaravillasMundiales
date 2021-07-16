using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class General : MonoBehaviour
{
    public GameObject Panel;
   public void ClosePanel(){
            Panel.SetActive(false);
            Time.timeScale=1;
    }
   public void SceneMenu(){
        SceneManager.LoadScene("Menu");
    }
}
