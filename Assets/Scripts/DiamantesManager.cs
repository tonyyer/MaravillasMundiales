using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DiamantesManager : MonoBehaviour
{
    public Text levelCleared;
    //public Animator animator; 

    public Text totalDiamantes;
    public Text DiamantesCollected;

    private int totalDiamantesInLevel;

    private void Start(){
        totalDiamantesInLevel=transform.childCount;
    }
    private void Update(){
        AllDiamantesCollected();
        totalDiamantes.text = totalDiamantesInLevel.ToString();
        DiamantesCollected.text=transform.childCount.ToString();
    }
    public void AllDiamantesCollected(){
        if(transform.childCount == 0){
            Debug.Log("Excelente Recolecto Todos los diamantes");
            //animator.Play("jugadorVictory");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene",1);
            
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
