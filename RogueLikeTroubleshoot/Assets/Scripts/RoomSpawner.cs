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


    private RoomTemplates Templates;
    private int Rand;
    private bool Spawned = false;


    void Start()
    {
        Templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f); 
    }


    void Spawn()
    {
        if(Spawned == false)
        {
            if (OpeningDirection == 1)
            {
                // Need to spawn a room with a BOTTOM door
                Rand = Random.Range(0, Templates.BottomRooms.Length);
                Instantiate(Templates.BottomRooms[Rand], transform.position, Templates.BottomRooms[Rand].transform.rotation);
            }

            else if (OpeningDirection == 2)
            {
                // Need to spawn a room with a TOP door
                Rand = Random.Range(0, Templates.TopRooms.Length);
                Instantiate(Templates.TopRooms[Rand], transform.position, Templates.TopRooms[Rand].transform.rotation);
            }

            else if (OpeningDirection == 3)
            {
                // Need to spawn a room with a LEFT door
                Rand = Random.Range(0, Templates.LeftRooms.Length);
                Instantiate(Templates.LeftRooms[Rand], transform.position, Templates.LeftRooms[Rand].transform.rotation);
            }

            else if (OpeningDirection == 4)
            {
                // Need to spawn a room with a RIGHT door
                Rand = Random.Range(0, Templates.RightRooms.Length);
                Instantiate(Templates.RightRooms[Rand], transform.position, Templates.RightRooms[Rand].transform.rotation);
            }

            Spawned = true;
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().Spawned == true)
            {
            Destroy(gameObject);
            }
    }

}
