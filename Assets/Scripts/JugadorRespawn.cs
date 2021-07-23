using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JugadorRespawn : MonoBehaviour
{
    public Animator animator; 
    public GameObject Panel;
    public void PlayerDamage(){
        animator.Play("death");
        Panel.SetActive(true);
        GetComponent<Jugador>().enabled=false;
    }
}
