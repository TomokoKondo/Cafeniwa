using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogBackground : MonoBehaviour {

	public GameObject dialog;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick() {
		if (dialog != null) {
			dialog.SetActive (false);
		}
	}
}
