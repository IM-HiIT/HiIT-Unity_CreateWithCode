using UnityEngine;

/** Player movement Script
* Accelerate, Decellerate
* Pitch, Yaw and Roll 
*/
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float thrust = 1000f;
    [SerializeField] private float thrust_mult = 30f;
    [SerializeField] private float yaw_mult = 160f;
    [SerializeField] private float pitch_mult = 160f;

    [SerializeField] private Rigidbody rigid;

    // Awake is called once the Script Instance is being loaded.
    void Awake() {
        rigid = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    // Fixed Update is called every fixed frame-rate frame.
    void FixedUpdate () {
        // Capture input
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");

        // Add relative Force on Z-Axis
        rigid.AddRelativeForce(0f, 0f, thrust * thrust_mult * Time.deltaTime);
        // Add relative Torque on X for Pitch and Y for Yaw
        rigid.AddRelativeTorque(pitch * pitch_mult * Time.deltaTime, yaw * yaw_mult * Time.deltaTime, -yaw * yaw_mult * 2 * Time.deltaTime);
    }
}
