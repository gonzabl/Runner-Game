using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
    }
}
