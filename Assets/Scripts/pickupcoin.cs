using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickupcoin : MonoBehaviour {

	public Text wynik;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			Destroy(this.gameObject);
			Debug.Log("Coin was picked up");
		}
	}
}
