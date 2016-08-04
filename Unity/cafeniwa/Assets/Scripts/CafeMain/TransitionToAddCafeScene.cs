using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionToAddCafeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void SceneLoad () {
		SceneManager.LoadScene("add_cafe");
	}
}
