using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour {

	MovieTexture movTex;

	void Start()
	{
		movTex = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
		movTex.Play(); // Autoplay on start
		movTex.loop = true; // Loop forever
	}

}
