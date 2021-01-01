using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other) // se ser necesario usar el parametro para especificar el nombre del objeto que queremos que lo detone
    {
        gameManager.CompleteLevel();
    }
}
