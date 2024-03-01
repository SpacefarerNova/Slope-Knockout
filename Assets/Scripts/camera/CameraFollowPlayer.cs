using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform cameraPos;
    public Transform player;
    void Update()
    {
        cameraPos.position = new Vector3(player.position.x, player.position.y + 0.5f, player.position.z - 2.5f);
    }
}
