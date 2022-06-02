using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimmer : MonoBehaviour
{
    [SerializeField] float steerSpeed = 5f;
    [SerializeField] float moveSpeed = 0.1f;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
