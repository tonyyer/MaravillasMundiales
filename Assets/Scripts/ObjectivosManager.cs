using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ObjectivosManager : MonoBehaviour
{
    public GameObject levelCleared;
    //public Animator animator; 

    public Text totalObjetos;
    public Text ObjetosCollected;

    private int totalObjetosInLevel;

    private void Start(){
        totalObjetosInLevel=transform.childCount;
    }
    private void Update(){
        AllObjetosCollected();
        totalObjetos.text = totalObjetosInLevel.ToString();
        ObjetosCollected.text=transform.childCount.ToString();
    }
    public void AllObjetosCollected(){
        if(transform.childCount == 0){
            Debug.Log("Excelente Recolecto Todos los Objetos");
            //animator.Play("jugadorVictory");
            levelCleared.gameObject.SetActive(true);
            //new WaitForSeconds(6);

            //Invoke("ChangeScene",1);
            
        }
    }


    void ChangeScene(){
        if(SceneManager.GetActiveScene().buildIndex < 2){
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }else{
            SceneManager.LoadScene("SampleScene");
        }
    }
}
