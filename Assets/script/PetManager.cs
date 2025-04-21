using UnityEngine;

public class PetManager : MonoBehaviour
{
    public PetController pet;
    public float OGmoveTimer, moveTimer;

    public static PetManager instance;

    private void Awake()
    {
        OGmoveTimer = moveTimer;
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetManager in the Scene");

    }
    private void Update()
    {
        if (moveTimer> 0 ){
            moveTimer -= Time.deltaTime;
        } else {
            // plan to move the pet side to side randomly.
            moveTimer = Random.Range(OGmoveTimer - 1f, OGmoveTimer + 1f);
        }
    }

    public void Die(){
        Debug.Log("dead");
    }

}
