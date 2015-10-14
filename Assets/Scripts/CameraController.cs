using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject player;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is done after all are done called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
