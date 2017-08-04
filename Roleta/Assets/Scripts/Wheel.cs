using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float torque;

    private Rigidbody2D rg2d;

    private void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    public void Spin()
    {
        float rnd = Random.Range(1, 10);

        rg2d.AddTorque(torque * rnd, ForceMode2D.Impulse);
    }

    public void Stop()
    {
        rg2d.angularVelocity = 0;
    }
}
