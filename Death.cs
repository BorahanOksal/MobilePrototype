using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) 
	{
		SceneManager.LoadScene ("Level", LoadSceneMode.Single);
	}
}
