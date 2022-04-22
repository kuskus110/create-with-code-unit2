using UnityEngine;

public class Hunger : MonoBehaviour
{
    #region Variables
    public int maxFoodAmount = 2;
    int currFoodAmount;
    HungerBar hungerBar;
    #endregion

    void Awake()
    {
        currFoodAmount = 0;
        hungerBar = transform.Find("HungerBar").Find("HungerBar").gameObject.GetComponent<HungerBar>();
    }

    void Start() {
        hungerBar.Init(maxFoodAmount);
    }

    public void Feed(int foodHungerValue) {
        currFoodAmount += foodHungerValue;
        hungerBar.SetFoodAmount(currFoodAmount);
        Invoke(nameof(KillIfSatisfied), .03f);
    }

    void KillIfSatisfied() {
        if (currFoodAmount >= maxFoodAmount) {
            Kill();
        }
    }

    void Kill() {
        ScoreCounter.scoreValue += 1;
        Destroy(gameObject);
    }
}
