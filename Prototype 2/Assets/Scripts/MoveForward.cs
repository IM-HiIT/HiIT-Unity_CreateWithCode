using UnityEngine;
public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40f; // Movement Speed
    void Update()
    {                             // Update is called once per frame
        transform.Translate(speed * Time.deltaTime * Vector3.forward);  // Move the GameObject forwards with speed 
    }
}
