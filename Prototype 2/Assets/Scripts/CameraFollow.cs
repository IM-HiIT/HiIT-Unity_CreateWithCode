using UnityEngine;

public class CameraFollow : MonoBehaviour
{
        [SerializeField] private Transform target;
        private float smoothSpeed = 0.125f;
        [SerializeField] private Vector3 posOffset;
        [SerializeField] private Vector3 rotOffset;

        private Vector3 smoothedPos;
        private Quaternion smoothedRot;

    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    void Update(){}

    // Fixed Update is called every fixed frame-rate frame.
    void FixedUpdate () {
        Vector3 desiredPos = target.position + target.rotation * posOffset;
        smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

        Quaternion desiredRot = target.rotation * Quaternion.Euler(rotOffset);
        smoothedRot = Quaternion.Lerp(transform.rotation, desiredRot, smoothSpeed);


        transform.position = smoothedPos;
        transform.rotation = smoothedRot;
    }

    // LateUpdate is called after Update once per frame
    void LateUpdate()
    {
        // Move the Camera + Offset
    
    }
}

