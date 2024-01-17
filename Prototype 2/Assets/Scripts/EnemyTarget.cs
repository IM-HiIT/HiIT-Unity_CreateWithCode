using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    [SerializeField] private GameObject turret;
    private bool isPlayerInRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider coll) {
        if (coll.CompareTag("Player")) {
            turret.transform.LookAt(coll.transform);
            isPlayerInRange = true;
        }
        isPlayerInRange = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
