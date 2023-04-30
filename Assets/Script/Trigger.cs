using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Finish") && other.CompareTag("Player"))
        {
             SceneManager.LoadScene(1);
        }
    }
}
