using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    private Rigidbody player1RB;
    private Rigidbody player2RB;

    [SerializeField] SpringJoint rope;

    public void Start()
    {
        player1RB = player1.GetComponent<Rigidbody>();
        player2RB = player2.GetComponent<Rigidbody>();

        rope.anchor = player2.transform.position;
        rope.connectedAnchor = player1.transform.position;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player1RB.AddForce(Vector3.forward * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player1RB.AddForce(Vector3.back * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player1RB.AddForce(Vector3.right * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player1RB.AddForce(Vector3.left * speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player2RB.AddForce(Vector3.forward * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player2RB.AddForce(Vector3.back * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player2RB.AddForce(Vector3.right * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player2RB.AddForce(Vector3.left * speed, ForceMode.Force);
        }
    }

}
