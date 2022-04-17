using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    public float speed = 20f;
    public Transform leftWall;
    public Transform rightWall;
    private float horizontalInput;
    private float leftBoundaryX;
    private float rightBoundaryX;
    private Vector3 translation;
    private Vector3 desiredLocation;
    #endregion

    void Start() {
        leftBoundaryX = leftWall.position.x;
        rightBoundaryX = rightWall.position.x;
    }   

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");        
    }

    void FixedUpdate() {
        if (horizontalInput != 0) {
            translation = Vector3.right * (horizontalInput * speed * Time.fixedDeltaTime);
            desiredLocation = transform.position + translation;
            if (leftBoundaryX < desiredLocation.x && desiredLocation.x < rightBoundaryX) {
                transform.Translate(translation);
            }
        }
    }
}
