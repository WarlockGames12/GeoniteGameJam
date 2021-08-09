using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform targetPlayer;
    private Vector3 Pos;


    // Update is called once per frame
    void LateUpdate()
    {
        Pos = targetPlayer.transform.position - gameObject.transform.position;
        Pos.z = 0;
        gameObject.transform.position += Pos / 20;
    }
}
