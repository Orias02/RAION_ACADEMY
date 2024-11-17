using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    

    public float currentInterval = 0f;
    public float Interval = 2f;
    public float maxDistance = 4f;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentInterval += Time.deltaTime;
        if (currentInterval >    Interval){
            currentInterval = 0f;
            Vector3 spawnPosition = transform.position;
            spawnPosition.z = Random.Range(-maxDistance, maxDistance);
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
}
}
