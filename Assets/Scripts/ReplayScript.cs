using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayScript : MonoBehaviour
{
    private const int bufferFrames = 100;
    private KeyFrame[] keyFrames = new KeyFrame[bufferFrames];

    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Record();
    }

    void PlayBack()
    {
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        transform.position = keyFrames[frame].position;
        transform.rotation = keyFrames[frame].rotation;
    }

    void Record()
    {
        rigidBody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        float time = Time.time;

        keyFrames[frame] = new KeyFrame(time, transform.position, transform.rotation);
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