using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JugadorRespawn : MonoBehaviour
{
    public Animator animator; 
    public GameObject Panel;


    public GameObject[] hearts;
    private int life;
    public AudioSource AudioHit;
    void Start(){
        life = hearts.Length;
    }
    public void CheckLife(){
        if(life < 1){
            Destroy(hearts[0].gameObject);
            animator.Play("death");
            Panel.SetActive(true);
            DisabledJugador();
            //GetComponent<Jugador>().enabled=false;
        }else if(life < 2){
            Destroy(hearts[1].gameObject);
            animator.Play("hit");
            AudioHit.Play();
        }else if(life < 3){
            Destroy(hearts[2].gameObject);
            animator.Play("hit");
            AudioHit.Play();
        }
    }

    public void PlayerDamage(){
        life--;
        CheckLife();
        //animator.Play("death");
        //Panel.SetActive(true);
        //GetComponent<Jugador>().enabled=false;
    }
    public void DisabledJugador(){
        GetComponent<Jugador>().enabled=false;
    }
}
