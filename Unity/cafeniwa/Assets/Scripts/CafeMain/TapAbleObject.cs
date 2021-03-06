﻿using UnityEngine;
using System.Collections;

public class TapAbleObject : MonoBehaviour {

	public GameObject dialog;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit)){
				dialog.SetActive (true);
				SetCouponDialog coupon = dialog.GetComponent<SetCouponDialog> () as SetCouponDialog;
				if (coupon != null) {
					coupon.SetCouponInfoTest ();
				}
			}
		}
	}
}
