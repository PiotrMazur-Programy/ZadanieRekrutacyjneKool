using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemy;
    public float height = 20;
    private bool spawned = true;

    public void Spawn()
    {
        UnityEngine.Vector3 pos = new UnityEngine.Vector3(gameObject.transform.position.x, height, gameObject.transform.position.z);
        GameObject o = GameObject.Instantiate(enemy);
        o.transform.position = pos;
      

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}