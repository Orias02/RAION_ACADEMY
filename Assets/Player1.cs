using UnityEngine;

public class Player1 : MonoBehaviour
{


    public float movementSpeed = 5f;
    public float maxDistance = 4f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Test Start"); 
    }

    // Update is called once per frame
    void Update()
    {
        float inputmovementX = Input.GetAxisRaw("Horizontal");
        Vector3 movementDirection = new Vector3();
        movementDirection.z = inputmovementX;
        //Debug.Log(inputmovementX);

        //transform.position = transform.position + (movementDirection * movementSpeed * Time.deltaTime);
    Vector3 directionOutput = transform.position + (movementDirection * movementSpeed * Time.deltaTime);
    transform.position = directionOutput;

    transform.position = new Vector3(
        transform.position.x,
        transform.position.y,
        Mathf.Clamp(transform.position.z, -maxDistance, maxDistance)
    );

    if (Input.GetMouseButtonDown(0))
    {
        Debug.Log("Input Logika Nembak");
    
    }
    
    }
}
