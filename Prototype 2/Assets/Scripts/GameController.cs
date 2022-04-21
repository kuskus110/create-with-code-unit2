using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region Variables
    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public static void EndGame() {
        print("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}