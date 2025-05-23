using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class dragObject : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    private Vector3 currentVelocity;
    public int sens = 20;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;

            Vector3 newPos = mouseWorldPosition + offset;
            currentVelocity = ((newPos - transform.position) / Time.deltaTime) / sens;

            rb.MovePosition(newPos);
        }
    }

    private void OnMouseDown()
    {
        rb.linearVelocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic; // Disable physics simulation

        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        offset = transform.position - mouseWorldPosition;

        dragging = true;
    }

    private void OnMouseUp() {
        dragging = false;
        rb.bodyType = RigidbodyType2D.Dynamic; // Re-enable physics
        rb.linearVelocity = currentVelocity;         // Apply drag momentum
    }
}
