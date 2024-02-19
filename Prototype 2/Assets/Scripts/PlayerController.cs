using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizInput;
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizInput = Input.GetAxis("Horizontal");
     transform.Translate(horizInput * speed * Time.deltaTime * Vector3.right);
    }
}
