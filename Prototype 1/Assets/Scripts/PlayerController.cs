using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed = 5.0f;

    private float horizInput;
    private float vertiInput;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        // Capture Input
        horizInput = Input.GetAxis("Horizontal");
        vertiInput = Input.GetAxis("Vertical");
        // Move the Vehicle Forward (20Meter per Second)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertiInput);
        // Turn the Vehicle
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizInput);
    }
}