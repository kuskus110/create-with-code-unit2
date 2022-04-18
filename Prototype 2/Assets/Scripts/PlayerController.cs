using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    public float speed = 20f;
    public Transform leftWall;
    public Transform rightWall;
    [SerializeField] private float horizontalInput;
    private float leftBoundaryX;
    private float rightBoundaryX;
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
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.fixedDeltaTime));
        float fixedPosX = Mathf.Clamp(transform.position.x, leftBoundaryX, rightBoundaryX);
        transform.position = new Vector3(fixedPosX, transform.position.y, transform.position.z);
    }
}
