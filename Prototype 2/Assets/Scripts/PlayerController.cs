using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float horizInput;   // Capture Input on Horizontal Axis (i.e. L-Arr/R-Arr, A/D)
    [SerializeField] private float speed = 10f; // The Speed with wich the player moves
    [SerializeField] private float boundary = 15f;  // The boundary of Playingfield where the player can move
    [SerializeField] private GameObject projectile; // Prefab of Projectile Gameobject to shoot

    void Update()
    {    // Update is called once per frame
        if (transform.position.x < -boundary)
        {     // If Player has reached boundary on the Left
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);    // Keep the player at the maximal left boundary
        }
        if (transform.position.x > boundary)
        {      // If Player has reached boundary on the Right
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);    // Keep the player at the maximal right boundary
        }
        horizInput = Input.GetAxis("Horizontal");       // Capture Horizontal Input
        transform.Translate(horizInput * speed * Time.deltaTime * Vector3.right);   // Move the Player on the X-axis, dependend on Input
        if (Input.GetKeyDown(KeyCode.Space))
        {  // Capture Spacebar Input
            Instantiate(projectile, transform.position, projectile.transform.rotation); // Spawn a Projectile on player
        }
    }
}
