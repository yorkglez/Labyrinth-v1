using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	// Use this for initialization
	//public defaultColor: Material;
	private Renderer render;
	public Material[] material;
	public GameObject[] objs;
	int i = 0;
	void Start () {
		//render = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			objs = GameObject.FindGameObjectsWithTag ("CubeL1");
			i = 0;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			GetComponent <MeshRenderer> ().material = material [1];
			objs = GameObject.FindGameObjectsWithTag ("CubeL2");
			i = 1;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			objs = GameObject.FindGameObjectsWithTag ("CubeL3");
			i = 2;
		}
			
		/*foreach (GameObject obj in objs) {
			obj.GetComponent <MeshRenderer> ().material = material[i];
		}	*/	
		
	}
}
