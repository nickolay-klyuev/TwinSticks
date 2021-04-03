using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public struct KeyFrame
{
    public float frameTime;
    public Vector3 position;
    public Quaternion rotation;

    public KeyFrame(float thisFrameTime, Vector3 thisPosition, Quaternion thisRotation)
    {
        frameTime = thisFrameTime;
        position = thisPosition;
        rotation = thisRotation;
    }
}