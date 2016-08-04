using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public Text text;
	public Canvas coupon_dialog;

	// Use this for initialization
	void Start () {
		if (text != null) {
			DataBaseHandler db = new DataBaseHandler ();
			User user = db.getUser (1);
			text.text = user.getName () + "のカフェ庭";
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
