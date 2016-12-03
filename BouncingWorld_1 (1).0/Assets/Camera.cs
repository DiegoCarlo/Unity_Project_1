using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public GameObject player;
	private Vector3 offset; // setta il valore dallo script se è privato. 
	/* voglio che sia la differenza tra la distanza della camera e la distanza del player
   */

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; // Transform è la finestra che indica le posizioni
	}

	// Update is called once per frame, each frame we can track the position of the game object and set the position of
	// the camera; but
	// it's better to use LATEUPDATE, that runs every frame just like Update, but it's guaranteed to run after
	// every item has been processed in Update. So when we set the position of the camera we know that the player
	// has moved for that frame.

	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}