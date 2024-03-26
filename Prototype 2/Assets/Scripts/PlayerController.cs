using UnityEngine;
public class PlayerController : MonoBehaviour
{
    /** Player Controller
    /* Capture Input on Horizontal Axis (i.e. L-Arr/R-Arr, A/D)
    /* The Speed with wich the player moves
    /* The boundary of Playingfield where the player can move
    /* Prefab of Projectile Gameobject to shoot
    */
    private float horizInput;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float boundary = 15f;
    [SerializeField] private GameObject projectile;

    /** Update
    /* Update is called once per frame
    /* If Player has reached boundary on the Left
    /* Keep the player at the maximal left boundary
    /* If Player has reached boundary on the Right
    /* Keep the player at the maximal right boundary
    /* Capture Horizontal Input
    /* Move the Player on the X-axis, dependend on Input
    /* Capture Spacebar Input
    /* Spawn a Projectile on player
    */
    void Update() {
        if (transform.position.x < -boundary) {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundary) {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        horizInput = Input.GetAxis("Horizontal");
        transform.Translate(horizInput * speed * Time.deltaTime * Vector3.right);
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
