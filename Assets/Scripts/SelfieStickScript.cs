using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfieStickScript : MonoBehaviour
{
    public float panSpeed = 10f;

    private GameObject rollerBall;
    private Vector3 armRotation;

    // Start is called before the first frame update
    void Start()
    {
        rollerBall = GameObject.FindGameObjectWithTag("Player");
        armRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        armRotation.y += Input.GetAxis("RHoriz") * panSpeed;
        armRotation.x += Input.GetAxis("RVertic") * panSpeed;

        transform.position = rollerBall.transform.position;
        transform.rotation = Quaternion.Euler(armRotation);
    }
}
