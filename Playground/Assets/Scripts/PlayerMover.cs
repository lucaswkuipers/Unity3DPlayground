using UnityEngine;


public class PlayerMover : MonoBehaviour
{
    [SerializeField] public float thrustMultiplier = 1000;
    [SerializeField] public float torqueMultiplier = 400;

    private Rigidbody rb;
    private bool isSpacePressed = false;
    private bool isLeftPressed = false;
    private bool isRightPressed = false;
    private bool isForwardPressed = false;
    private bool isBackwardPressed = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ProcessInput();
    }

    private void FixedUpdate()
    {
        ProcessThrust();
        ProcessTorque();
    }

    void ProcessInput()
    {
        isSpacePressed = Input.GetKey(KeyCode.Space);
        isLeftPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        isRightPressed = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        isForwardPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        isBackwardPressed = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
    }

    void ProcessThrust()
    {
        if (!isSpacePressed) { return; }
        Debug.Log("Main thrust activated");
        rb.AddRelativeForce(Vector3.up * Time.deltaTime * thrustMultiplier);
    }

    void ProcessTorque()
    {
        rb.freezeRotation = true;
        if (isLeftPressed)
        {
            Debug.Log("Rotating left");
            //rb.AddRelativeTorque(Vector3.forward * Time.deltaTime * torqueMultiplier);
            transform.Rotate(Vector3.forward * Time.deltaTime * torqueMultiplier);
        }

        if (isRightPressed)
        {
            Debug.Log("Rotating right");
            //rb.AddRelativeTorque(Vector3.back * Time.deltaTime * torqueMultiplier);
            transform.Rotate(Vector3.back * Time.deltaTime * torqueMultiplier);
        }

        if (isForwardPressed)
        {
            Debug.Log("Rotating forward");
            //rb.AddRelativeTorque(Vector3.right * Time.deltaTime * torqueMultiplier);
            transform.Rotate(Vector3.right * Time.deltaTime * torqueMultiplier);
        }

        if (isBackwardPressed)
        {
            Debug.Log("Rotating backward");
            //rb.AddRelativeTorque(Vector3.left * Time.deltaTime * torqueMultiplier);
            transform.Rotate(Vector3.left * Time.deltaTime * torqueMultiplier);
        }

        rb.freezeRotation = false;
    }
}
