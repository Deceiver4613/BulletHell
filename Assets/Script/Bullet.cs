using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 8f;

    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
        }

        if(!other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
       
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
  
}
