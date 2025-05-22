using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
 
    }
 
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

 
    // Get the rightmost position of the screen in world space
    float screenRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

    // Spawn pipe at the right edge of the screen
    Instantiate(pipe, new Vector3(screenRight + 2f, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}