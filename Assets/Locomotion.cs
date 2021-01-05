    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    public Transform player;
    public Vector3 heightOffset;
    public Vector3 deltaPos;
    private Vector3 newPos;

    public void TeleportPlayer(Vector3 newPosition)
    {
        newPos = newPosition + heightOffset;
        player.position = newPos;
        //deltaPos = player.position - newPos;
    }

    /*void Update ()
    {
        while(player.position.x != newPos.x || player.position.y != newPos.y || player.position.z != newPos.z)
        {
            deltaPos = new Vector3(0, 0, 0);
            if (player.position.x < newPos.x)
                deltaPos.x += 1;
            else if (player.position.x > newPos.x)
                deltaPos.x -= 1;

            if (player.position.y < newPos.y)
                deltaPos.y += 1;
            else if (player.position.y > newPos.y)
                deltaPos.y -= 1;

            if (player.position.z < newPos.z)
                deltaPos.z += 1;
            else if (player.position.z > newPos.z)
                deltaPos.z -= 1;

            player.position = player.position + deltaPos;
        }
    }*/
}
