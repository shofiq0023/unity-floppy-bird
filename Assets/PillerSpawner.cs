using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerSpawner : MonoBehaviour
{
    public GameObject piller;
    public float heightOffset = 10;
    public float spawRate = 2;
    private float timer = 0;

    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        pillerSpawn();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawRate) 
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (logic.stop == false)
            {
                pillerSpawn();
                timer = 0;
            }
        }
    }

    void pillerSpawn()
    {
        float highestPoint = transform.position.y - heightOffset;
        float lowestPoint = transform.position.y + heightOffset;

        Instantiate(piller, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
