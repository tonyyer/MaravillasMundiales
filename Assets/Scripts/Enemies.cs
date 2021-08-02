using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] List<Transform> wayPoints = null;
    float velocidad = 4;
    float distanciaCambio = 0.2f;
    byte siguientePosicion = 0;

    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spriteRenderer.flipX=false;
        transform.position = Vector3.MoveTowards(
            transform.position,
            wayPoints[siguientePosicion].transform.position,
            velocidad * Time.deltaTime);
            // Debug.Log("iniciando");

        if (Vector3.Distance(transform.position,
            wayPoints[siguientePosicion].transform.position) < distanciaCambio)
        {
            spriteRenderer.flipX=false;
                Debug.Log("segundo if");
            //spriteRenderer.flipX=true;
            siguientePosicion++;
            if (siguientePosicion >= wayPoints.Count){
           // spriteRenderer.flipX=true;
                siguientePosicion = 0;
                Debug.Log("tercer if");
                spriteRenderer.flipX=true;

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //FindObjectOfType<GameController>().SendMessage("PerderVida");
    }
}
