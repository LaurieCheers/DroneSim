using UnityEngine;
using System.Collections;

public class DroneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        float strength = 8.5f;
        Vector3 thrust = transform.TransformPoint(new Vector3(0, strength, 0)) - transform.TransformPoint(Vector3.zero);
        //Debug.Log(thrust);

        if (Input.GetButton("Fire1") || Input.GetKey(KeyCode.W))
        {
            body.AddForceAtPosition(thrust,
                transform.TransformPoint(new Vector3(2, 0, 2)));
        }

        if (Input.GetButton("Fire2") || Input.GetKey(KeyCode.S))
        {
            body.AddForceAtPosition(thrust,
                transform.TransformPoint(new Vector3(-2, 0, 2)));
        }

        if (Input.GetButton("Fire3") || Input.GetKey(KeyCode.A))
        {
            body.AddForceAtPosition(thrust,
                transform.TransformPoint(new Vector3(2, 0, -2)));
        }

        if (Input.GetButton("Jump") || Input.GetKey(KeyCode.D))
        {
            body.AddForceAtPosition(thrust,
                transform.TransformPoint(new Vector3(-2, 0, -2)));
        }
    }

    void OnGUI()
    {
        if (Input.GetButton("Fire1"))
        {
            GUI.Label(new Rect(25, 75, 100, 100), "Fire1");
        }
        if (Input.GetButton("Fire2"))
        {
            GUI.Label(new Rect(50, 50, 100, 100), "Fire2");
        }
        if (Input.GetButton("Fire3"))
        {
            GUI.Label(new Rect(0, 50, 100, 100), "Fire3");
        }
        if (Input.GetButton("Jump"))
        {
            GUI.Label(new Rect(25, 25, 100, 100), "Jump");
        }
    }
}
