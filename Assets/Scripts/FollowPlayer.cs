using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offset; // distancia a la cual la camara seguira al player


    // Update is called once per frame
    void Update()
    {
        // usando esta manera la camara seguira en linea recta al player y no rotara sobre el mismo, que es lo que ocurriria si ponemos la camara como
        // hijo del player
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
