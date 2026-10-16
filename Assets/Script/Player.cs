using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(direction.magnitude > 0)
        {
            direction.Normalize();
        }
        rb.linearVelocity = direction * speed;
    }
}
