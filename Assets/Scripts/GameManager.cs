using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("Game over!");
            Invoke("Restart", restartDelay); // Llama a una funcion con un determinado retrazo de tiempo 
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Se le pasas como parametro la escena o nivel actual que esta cargado
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); // activa nuevamente el objecto con la interfaz de nivel completado
    }
}
