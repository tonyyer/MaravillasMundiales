using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject Panel;
   public void ClosePanel(){
            Panel.SetActive(false);
            Time.timeScale=1;
    }
}
