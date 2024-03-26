using UnityEngine;
public class DestroyOutOfBounds : MonoBehaviour
{
    /** Destroy Out of Bounds
    /* Threshold before Out Of Bound on Z-Axis
    */
    [SerializeField] private float outOfBound = 10f;

    /** Update
    /* Update is called once per frame
    /* If this gameObject is passed 3times the Bounds (i.e. 30f) or if its below negative Bounds (i.e -10f)
    /* Destroy this gameObject
    */
    void Update() {
        if ((transform.position.z > outOfBound * 3) || (transform.position.z < -outOfBound)) {
            Destroy(gameObject);
        }
    }
}
