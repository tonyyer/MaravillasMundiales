using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollected : MonoBehaviour
{
   public GameObject Panel;
   public GameObject Objeto;
 private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            Debug.Log("si hay");
            Panel.SetActive(true);
            Time.timeScale=0;
            Objeto.SetActive(false);
            GetComponent<SpriteRenderer>().enabled=false;
            
        }else{
            Debug.Log("no hay colision");
        }
    }
}
