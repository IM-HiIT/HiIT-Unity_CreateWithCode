using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset;// = new Vector3(0, 5f, -8.5f);
    private Quaternion rotation;
    private bool isChaseCam = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            isChaseCam = !isChaseCam;
        }
    }

    void Update()
    {
        if (isChaseCam)
        {
            offset = new Vector3(0, 5f, -8.5f);
            rotation = new Quaternion();
        }
        else
        {
            offset = new Vector3(0, 2.15f, 0.3f);
            rotation = player.transform.rotation;
        }
    }

    // LateUpdate is called after Update once per frame
    void LateUpdate()
    {
        // Move the Camera + Offset
        transform.position = player.transform.position + offset;
        transform.rotation = rotation;
    }
}
