using UnityEngine;

public class BulletSpawnner : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Transform target;

    public float interval = 1f;
    private float timer = 0f;
    private void Start()
    {
        GameObject findgo = GameObject.FindWithTag("Player");
        target = findgo.transform;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > interval)
        {
            timer = 0f;
            Spawn();
        }
    }
    
   private void Spawn()
    {
        Vector3 position = transform.position;
        Vector3 direction = target.position - position;
        direction.Normalize();
        Quaternion rotation = Quaternion.LookRotation(direction);
        Instantiate(bulletPrefab, position, rotation);
    }

}
