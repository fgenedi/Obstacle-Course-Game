using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    private int timeStamp = 3;

    private Rigidbody rigidBody;

    private MeshRenderer meshRenderer;

    private bool dropped = false;

    private void Awake()
    {
        this.rigidBody = GetComponent<Rigidbody>();
        this.meshRenderer = GetComponent<MeshRenderer>();

        this.rigidBody.useGravity = false;
        //this.meshRenderer.enabled = false;

    }

    void Update()
    {
        if(Time.time >= timeStamp && !dropped)
        {
            dropped = true;
            Drop();
        }
    }

    void Drop()
    {
        //Debug.Log("drop now");
        this.rigidBody.useGravity = true;
        //this.meshRenderer.enabled = true;
    }
}
