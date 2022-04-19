using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    public float speed = 20f;
    public Transform leftWall;
    public Transform rightWall;
    public Transform topWall;
    public Transform bottomWall;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    private float leftBoundaryX;
    private float rightBoundaryX;
    private float topBoundaryZ;
    private float bottomBoundaryZ;
    #endregion

    void Start() {
        leftBoundaryX = leftWall.position.x;
        rightBoundaryX = rightWall.position.x;
        topBoundaryZ = topWall.position.z;
        bottomBoundaryZ = bottomWall.position.z;
    }   

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate() {
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * (speed * Time.fixedDeltaTime));
        float fixedPosX = Mathf.Clamp(transform.position.x, leftBoundaryX, rightBoundaryX);
        float fixedPosZ = Mathf.Clamp(transform.position.z, bottomBoundaryZ, topBoundaryZ);
        transform.position = new Vector3(fixedPosX, transform.position.y, fixedPosZ);
    }
}
