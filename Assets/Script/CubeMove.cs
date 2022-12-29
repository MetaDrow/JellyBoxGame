
using UnityEngine;
using UnityEngine.SceneManagement;


public class CubeMove : MonoBehaviour
{
	[SerializeField] KeyCode KeyOne;
	[SerializeField] KeyCode KeyTwo;
	[SerializeField] Vector3 MoveDirection;
	[SerializeField] Rigidbody CubeRigidBody;
	[SerializeField] public float MoveForce = 0.2f;

	private void Start ()
	{
		GetComponent<Rigidbody>();
	}

	private void FixedUpdate ()
	{
		Move();

	}
	private void Update ()
	{
		Restart();
	}

	private void Move ()
	{
		if(Input.GetKey(KeyOne))
		{
			CubeRigidBody.velocity -= MoveDirection * MoveForce;
		}
		if(Input.GetKey(KeyTwo))
		{
			CubeRigidBody.velocity += MoveDirection * MoveForce;
		}
	}

	private void Restart()
	{
		if(Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	private void OnTriggerEnter (Collider other)
	{
		if(this.CompareTag("Player") && other.CompareTag("Finish"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		}
	}
}
