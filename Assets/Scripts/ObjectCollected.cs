using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ObjectCollected : MonoBehaviour
{
   public GameObject Panel;
   public GameObject Objeto;
   //public AudioSource AudioCollected;
   //public String objecto;
 private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            //AudioCollected.Play();
            Debug.Log("si hay");
            Panel.SetActive(true);
            Time.timeScale=0;
            Objeto.SetActive(false);
            GetComponent<SpriteRenderer>().enabled=false;
            //GetComponent<Jugador>().enabled=false;
            Destroy(gameObject,0.5f);
        }else{
            Debug.Log("no hay colision");
        }
    }
}
