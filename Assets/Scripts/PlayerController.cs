using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float x = Input.acceleration.x;
        float y = Input.acceleration.y;
       // Vector3 movement = new Vector3(x, 0.0f, y);
        Vector3 movement = new Vector3(x, 0.0f, y);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }

}