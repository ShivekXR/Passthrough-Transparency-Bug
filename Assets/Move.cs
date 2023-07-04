using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	private Transform t;
	float time = 0;

    void Start()
    {
        t = GetComponent<Transform>();
    }

    void Update()
    {
		time += Time.deltaTime * 3;
		var x = Mathf.Abs(time % 16 - 8) - 4;
        t.localPosition = new Vector3(x, 0.25f, 0);
    }
}
