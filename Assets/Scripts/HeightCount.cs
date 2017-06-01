using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightCount : MonoBehaviour {

	public Transform player;
	int maxHeight;
	Text text;
	// Use this for initialization
	void Start () {
		maxHeight = 0;
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		int height = (int) player.position.y;
		if (height > maxHeight) {
			maxHeight = height;
			text.text = height.ToString();
		}
	}
}
