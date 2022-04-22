using UnityEngine;
using UnityEngine.UI;   

public class HungerBar : MonoBehaviour
{
    #region Variables
    Slider slider;
    #endregion

    void Awake() {
        slider = GetComponent<Slider>();
    }

    public void Init(int maxFoodAmount) {
        slider.maxValue = maxFoodAmount;
        slider.value = 0; 
    }

    public void SetFoodAmount(int foodAmount) {
        slider.value = foodAmount;
    }
}
