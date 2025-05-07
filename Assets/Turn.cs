using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public float speed = 180;
    public string player = "Player 1";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 0,
                          Input.GetAxis(player) * speed * Time.deltaTime,
                          0
                        );
    }
}
