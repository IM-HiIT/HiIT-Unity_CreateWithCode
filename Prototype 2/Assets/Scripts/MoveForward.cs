using UnityEngine;
public class MoveForward : MonoBehaviour
{
    /** Move Forward
    /* Movement Speed
    */
    [SerializeField] private float speed = 40f;

    /** Update
    /* Update is called once per frame
    /* Move the GameObject forwards with speed 
    */
    void Update() {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
