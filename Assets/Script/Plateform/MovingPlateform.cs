using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateform : MonoBehaviour
{
    float initialHeight;

    public float elevationValue;

    bool goingUp;
    bool goingDown;
    // Start is called before the first frame update
    void Start()
    {
        initialHeight = transform.position.y;
        goingUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1 * Time.deltaTime, 0);
            if (transform.position.y > initialHeight + elevationValue)
            {
                goingUp = false;
                goingDown = true;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1 * Time.deltaTime, 0);
            if (transform.position.y < initialHeight - elevationValue)
            {
                goingDown = false;
                goingUp = true;
            }
        }
    }
}
