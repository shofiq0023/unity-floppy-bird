using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float flapStr;
    public LogicScript logic;
    private bool isBirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive) {
            rigidBody.velocity = Vector2.up * flapStr;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        isBirdAlive = false;
    }
}
