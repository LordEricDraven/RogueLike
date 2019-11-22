using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public int OpeningDirection;
    // 1 --> need bottom door
    // 2 --> need top door
    // 3 --> need left door
    // 4 --> need right door


    private void Update()
    {
        if(OpeningDirection == 1)
        {
            // Need to spawn a room with a BOTTOM door
        }

        else if(OpeningDirection == 2)
        {
            // Need to spawn a room with a TOP door
        }

        else if(OpeningDirection == 3)
        {
            // Need to spawn a room with a LEFT door
        }

        else if(OpeningDirection == 4)
        {
            // Need to spawn a room with a RIGHT door
        }
    }

}
