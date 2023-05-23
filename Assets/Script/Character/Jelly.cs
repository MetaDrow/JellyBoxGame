
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public GameObject[] _bones;
    public Vector3 _center;
    void FixedUpdate()
    {
        for (int i = 0; i < _bones.Length; i++)
        {
            _center += _bones[i].transform.position;
        }
        _center = _center / _bones.Length;
        transform.position = _center;
    }
}

