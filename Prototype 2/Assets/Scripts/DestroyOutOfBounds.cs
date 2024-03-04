using UnityEngine;
public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float outOfBound = 10f;            // Threshold before Out Of Bound on Z-Axis
    void Update()
    {                                             // Update is called once per frame
        if ((transform.position.z > outOfBound * 3) || (transform.position.z < -outOfBound))
        {     // When this gameObject is passed 3times the Bounds (i.e. 30f) or if its below negative Bounds (i.e -10f)
            Destroy(gameObject);                                                                 // Destroy this gameObject
        }
    }
}
