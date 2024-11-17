using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject,life);

        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)

    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
