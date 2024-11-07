using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;         // How hard the ball is pushed
    private float xDirection;    // Move the ball left and right
    private float zDirection;    // Move the ball forward and backwards

    void Start()
    {
        speed = 10;
    }

    private void Update()
    {
        MoveBall();    // Listens for the player clicking arrows or W-A-S-D keys.
    }

    // Moves the Ball
    private void MoveBall ()
    {
        xDirection = Input.GetAxis("Horizontal"); //Uses player input to move the ball.
        zDirection = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(xDirection, 0, zDirection);
        GetComponent<Rigidbody>().AddForce(direction * speed);
    }

    // Called when collides with trigger
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}