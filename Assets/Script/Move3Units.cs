using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3Units : MonoBehaviour {

    // public GameObject r1,r2,r3;

    public GameObject[] rs;
	// Use this for initialization
	void Start () {

	}
    float timer = 0;
    bool turnRight = false;
    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        //r1.transform.position = new Vector3((r1.transform.position.x + 1), 0, 0);
        //r2.transform.position = new Vector3((r2.transform.position.x + 2), 0, 0); 
        //r3.transform.position = new Vector3((r3.transform.position.x + 3), 0, 0);
        Debug.Log(timer);

        foreach (var r in rs)
        {
            if (r.transform.position.x > 15)
            {
                turnRight = false;
                timer = 0.1f;
            }
            if (r.transform.position.x < -7)
            {
                turnRight = true;
                timer = 0.1f;
            }

            if(turnRight)
                r.transform.position = new Vector3((r.transform.position.x + timer), 0, 0);
                // r.transform.TransformVector(new Vector3(100.0f, 0, 0));
            else
                r.transform.TransformVector(new Vector3(-100.0f, 0, 0));
                //r.transform.position = new Vector3((r.transform.position.x - timer), 0, 0);



            // r.transform.TransformVector(new Vector3((100 * timer), 0, 0));
        }
    }



}
