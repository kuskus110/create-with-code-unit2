using UnityEngine;

public class IncreaseScoreOnKill : MonoBehaviour
{
    #region Variables
    public string enemiesGameTag;
    #endregion

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag(enemiesGameTag)) {
            ScoreCounter.scoreValue += 1;
            print("Score = " + ScoreCounter.scoreValue.ToString());
        }
    }
}
