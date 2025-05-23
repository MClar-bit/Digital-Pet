using UnityEngine;




public class FoodSpawn : MonoBehaviour
{
    public GameObject food;
    public float offset = 2;

    public void spawnFood()
    {
        float lowestPoint = transform.position.x - offset;
        float highestPoint = transform.position.x + offset;

        Instantiate(food, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 0), transform.rotation);
    }
    
    
}
