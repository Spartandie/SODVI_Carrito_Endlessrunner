using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{

    public GameObject theGround;
    public Transform generationPoint;
    public float distanceBetween;

    private float groundWidth;

    // Start is called before the first frame update
    void Start()
    {
        groundWidth = theGround.GetComponent<BoxCollider2D>().size.x;//Width of the ground
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(theGround, transform.position, transform.rotation);
        }
    }
}
