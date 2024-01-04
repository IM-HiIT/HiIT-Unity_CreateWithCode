using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float turnSpeed = 25.0f;

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

        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertiInput);
        // Turn the Vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizInput);
    }
}