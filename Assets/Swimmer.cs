using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimmer : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(0, 0, 5);
        transform.Translate(0, 0.1f, 0);
    }
}
