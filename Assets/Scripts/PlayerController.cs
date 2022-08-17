using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerBody;
    public float speed = 1000;
    private int score = 0;

    // triggered for Toss a coin for your Witcher
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update the movement of the player
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        playerBody.AddForce(movement * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
