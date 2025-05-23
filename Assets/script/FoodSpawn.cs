using UnityEngine;




public class FoodSpawn : MonoBehaviour
{
    public GameObject food;
    public float offset = 10;

    public void spawnFood() {

    Instantiate(food, new Vector3(transform.position.x, transform.position.y,  0), transform.rotation);
    }
}
