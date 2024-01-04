using UnityEngine;

public class PlayerControllerX : MonoBehaviour {

    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float pitchSpeed = 25.0f;

    private float vertiInput;
    private float horizInput;
    

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
        // Capture Input
        vertiInput = Input.GetAxis("Vertical");
        horizInput = Input.GetAxis("Horizontal");

        // Accelerate/Dexcelerate
        transform.Translate(vertiInput * speed * Time.deltaTime * Vector3.forward);
        // Yaw
        //transform.Rotate(Vector3.up, Time.deltaTime * pitchSpeed * horizInput);
        // Pitch
        transform.Rotate(Vector3.left, horizInput * pitchSpeed * Time.deltaTime);
    }
}