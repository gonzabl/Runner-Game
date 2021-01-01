using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() // este metodo debe seleccionarse al agregar en animator un track de evento
    {
        // pasa como parametro el siguiente nivel de la escena actual tomado como referencia el indice que figura en las escenas cargadas
        // de build settings, ubicado en la pestaña file. 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
                                                                                    
    }
}
