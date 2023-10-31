using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float ySpeed = -5f * Time.deltaTime;
        transform.Rotate(0, ySpeed, 0);
    }
}
