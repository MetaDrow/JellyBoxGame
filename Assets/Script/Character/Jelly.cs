
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public GameObject[] Bones;
    public Vector3 Center;
    void FixedUpdate()
    {
        for (int i = 0; i < Bones.Length; i++)
        {
            Center += Bones[i].transform.position;
        }
        Center = Center / Bones.Length;
        transform.position = Center;
    }
}

