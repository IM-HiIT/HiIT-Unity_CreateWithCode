using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float horizInput;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float boundary = 15f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x < -boundary) {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundary) {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        horizInput = Input.GetAxis("Horizontal");
        transform.Translate(horizInput * speed * Time.deltaTime * Vector3.right);
    }
}
