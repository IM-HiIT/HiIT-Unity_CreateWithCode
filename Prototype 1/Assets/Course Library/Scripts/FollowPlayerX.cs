using UnityEngine;

public class FollowPlayerX : MonoBehaviour {
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(20f, 3f, 0f);

    // Start is called before the first frame update
    void Start() {
    }

    // LateUpdate is called after Update once per frame
    void LateUpdate() {
        // Move the Camera + Offset
        transform.position = player.transform.position + offset;
    }
}
