using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Generator : MonoBehaviour {

    //Start point from where rooms will be generated 
    public Transform Start_point;
    //List of rooms 
    public GameObject[] Rooms;
    //How many rooms to spawn 
    public int Room_amount;
    //Margin between rooms
    public float Move_X;
    public float Move_Y;

    void Start () {
        //Find start point and spawn first room
        transform.position = Start_point.position;
        Instantiate(Rooms[0], transform.position, Quaternion.identity);
        //Move to generation procedure
        Move_and_Spawn();

	}

	void Move_and_Spawn() {
        //If not enough rooms, spawn more
        int Rooms_spawned = 0;
        while (Rooms_spawned < Room_amount)
        {
            //Pick next room direction 
            int dir_index = Random.Range(0, 5);
            //if 0 or 1 spawn room to the left
            if (dir_index == 0 || dir_index == 1)
            {
                //Set position for new room and assing it
                Vector2 new_Room_pos = new Vector2(transform.position.x - Move_X, transform.position.y);
                transform.position = new_Room_pos;
            }
            //if 2 or 3 spawn room to the right
            else if (dir_index == 2 || dir_index == 3)
            {
                //Set position for new room and assing it
                Vector2 new_Room_pos = new Vector2(transform.position.x + Move_X, transform.position.y);
                transform.position = new_Room_pos;
            }
            //if 4 or 5 spawn room to the bottom 
            else if (dir_index == 4 || dir_index == 5)
            {
                //Set position for new room and assing it
                Vector2 new_Room_pos = new Vector2(transform.position.x, transform.position.y - Move_Y);
                transform.position = new_Room_pos;
            }
            //Instantiate room
            Instantiate(Rooms[0], transform.position, Quaternion.identity);
            //Increase the amount of rooms spawned
            Rooms_spawned++;
        }
    }
}
