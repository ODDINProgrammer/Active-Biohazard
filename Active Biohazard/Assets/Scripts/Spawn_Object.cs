using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Object : MonoBehaviour {

    //List of objects to pick up from 
    public GameObject[] Objects;

	void Start () {
        //Pick a random object from list
        int index = Random.Range(0, Objects.Length);
        //Instantiate the object
        GameObject instance = (GameObject)Instantiate(Objects[index], transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }
}
