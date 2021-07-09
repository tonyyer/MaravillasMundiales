using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JugadorRespawn : MonoBehaviour
{
    public Animator animator; 
    public void PlayerDamage(){
        animator.Play("jugadorMuerte");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
