using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Vector3 cameraDisplacement;
    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        cameraDisplacement = ball.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position - cameraDisplacement;
    }
}
