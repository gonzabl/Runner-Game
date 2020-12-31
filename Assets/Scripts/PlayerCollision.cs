using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    public GameObject destructible;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name); // no muy eficiente ademas de que si el nombre cambia este no sera efectivo
        //Debug.Log(collision.collider.tag); // agrupar mejor varios obj con una sola etiqueta
        
        if (collision.collider.tag == "Obstacle")
        {
            // para usar alguno de estos 2 deben estar los elementos referenciados en la escena.

            movement.enabled = false; // Se puede escribir  como GetComponent<playerMovement>(); sin necesidad de la variable publica de arriva.
            FindObjectOfType<GameManager>().EndGame(); // mismo pero para el Script

            Instantiate(destructible, transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
