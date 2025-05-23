using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PipieMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone){
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
