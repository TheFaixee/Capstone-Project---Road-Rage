using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;

    public GameObject car;
    

    // Update is called once per frame
    void Update()
    {
        X = car.transform.eulerAngles.x;
        Y = car.transform.eulerAngles.y;
        Z = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(X - X, Y, Z - Z);
    }
}
