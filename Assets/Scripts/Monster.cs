using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    [HideInInspector]
    public float enemySpeed;
    private void Awake()
    {


        myBody = gameObject.GetComponent<Rigidbody2D>();


    }
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        myBody.velocity = new Vector2(enemySpeed, myBody.velocity.y);
    }
}
