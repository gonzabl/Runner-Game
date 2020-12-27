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
            movement.enabled = false;
            Instantiate(destructible, transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
