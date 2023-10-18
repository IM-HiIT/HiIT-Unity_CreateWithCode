using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the Camera + Offset
        transform.position = player.transform.position + new Vector3(0, 5, -8.5f);
    }
}
