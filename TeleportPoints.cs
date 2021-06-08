using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    public GameObject CameraRig;

    public void Teleport()
    {
        CameraRig.transform.position = new Vector3(
            transform.position.x,
            transform.position.y + 2f,
            transform.position.z
            );
    }
}
