using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {          
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
