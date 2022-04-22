using UnityEngine;

public class FeedAnimalOnCollision : MonoBehaviour
{
    #region Variables
    public string animalGameTag;
    #endregion

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag(animalGameTag)) {
            other.GetComponent<Hunger>().Feed(1);
        }
    }
}
