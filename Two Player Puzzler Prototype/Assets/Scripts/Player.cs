using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    private float tether = 10;



    private void Update()
    {
        if (Vector3.Distance(player1.transform.position, player2.transform.position) < tether)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player1.transform.position += Vector3.forward * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                player1.transform.position += Vector3.back * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                player1.transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player1.transform.position += Vector3.left * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.W))
            {
                player2.transform.position += Vector3.forward * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                player2.transform.position += Vector3.back * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                player2.transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                player2.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
    }

}
