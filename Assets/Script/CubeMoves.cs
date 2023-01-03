using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoves : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] Vector3 MoveDirection;
    [SerializeField] Rigidbody CubeRigidBody;
    [SerializeField] Rigidbody CubeRigidBody2;
	 [SerializeField] Rigidbody CubeRigidBody3;
	  [SerializeField] Rigidbody CubeRigidBody4;
    [SerializeField] public float MoveForce = 0.2f;
    private void Start()
    {
        GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        if (Input.GetKey(KeyOne))
        {
            CubeRigidBody.velocity -= MoveDirection * MoveForce;
            CubeRigidBody2.velocity -= MoveDirection * MoveForce;
			CubeRigidBody3.velocity -= MoveDirection * MoveForce;
			CubeRigidBody4.velocity -= MoveDirection * MoveForce;
        }
        if (Input.GetKey(KeyTwo))
        {
            CubeRigidBody.velocity += MoveDirection * MoveForce;
            CubeRigidBody2.velocity += MoveDirection * MoveForce;
			CubeRigidBody3.velocity += MoveDirection * MoveForce;
			CubeRigidBody4.velocity += MoveDirection * MoveForce;
        }
    }
}
