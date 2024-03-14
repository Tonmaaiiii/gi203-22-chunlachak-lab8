using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlaneMove : MonoBehaviour
{

    public float moveSpeed = 5f; 
    private Rigidbody rd;
    public float rotationSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical * moveSpeed * Time.deltaTime;
        rd.MovePosition(rd.position + movement);
    }

    void Rotate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float rotation = horizontal * rotationSpeed * Time.deltaTime;
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * rotation);
        rd.MoveRotation(rd.rotation * deltaRotation);
    }
}
