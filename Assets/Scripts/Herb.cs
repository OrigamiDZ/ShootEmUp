using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herb : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private Boundary boundary;

    private Vector2 position;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        position = transform.position;
        Vector3 newPosition = position + speed * Vector2.left * Time.deltaTime;
        newPosition[0] = Mathf.Clamp(newPosition[0], boundary.minX, boundary.maxX);
        newPosition[1] = Mathf.Clamp(newPosition[1], boundary.minY, boundary.maxY);

        transform.position = newPosition;
    }
}
