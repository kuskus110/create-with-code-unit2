using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    #region Variables
    public int playerLives;
    public int startingValue = 3;
    #endregion

    void Awake()
    {
        playerLives = startingValue;
    }

    void Update()
    {
        if (playerLives <= 0) {
            GameController.EndGame();
        }
    }

    public void HitPlayer() {
        playerLives -= 1;
        print("Lives = " + playerLives);
    }
}
