using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollected : MonoBehaviour
{
   public GameObject Panel;
   public GameObject Objeto;
   //public String objecto;
 private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            Debug.Log("si hay");
            Panel.SetActive(true);
            Time.timeScale=0;
            Objeto.SetActive(false);
            GetComponent<SpriteRenderer>().enabled=false;
            Destroy(gameObject,0.5f);
        }else{
            Debug.Log("no hay colision");
        }
    }
}
