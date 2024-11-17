using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    public GameObject Player;

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position;
        
    }
}
