using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // to make boundary visible in Inspector
public class Boundary
{
    public float minX, minY, maxX, maxY;
}

public class Engine : MonoBehaviour {

    private BaseAvatar avatar;
    private Vector2 position;

    [SerializeField]
    private Boundary boundary;

    // Use this for initialization
    void Start () {
        avatar = GetComponent<BaseAvatar>();
    }

    public void Move(Vector2 speed) 
    {
        position = transform.position;
        Vector3 newPosition = position + speed * avatar.getMaxSpeed() * Time.deltaTime;
        newPosition[0] = Mathf.Clamp(newPosition[0], boundary.minX, boundary.maxX);
        newPosition[1] = Mathf.Clamp(newPosition[1], boundary.minY, boundary.maxY);

        transform.position = newPosition;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
