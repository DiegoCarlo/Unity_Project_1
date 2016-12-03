using UnityEngine;
using System.Collections;

public class SquareSheep : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){ //Codice chiamato ogni volta che il Player tocca un trigger collider (i cubi)
		if (other.gameObject.CompareTag("Ground")) { //se l'oggetto con cui collide il player ha un tag "Ground":
			// Per poter usare un tag, questo va prima aggiunto nell'elenco dei tag ed assegnato all'oggetto voluto
			//other.gameObject.SetActive(false); // Questo fa sparire l'oggetto

			print(gameObject.name);

			GameObject newPec = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			newPec = gameObject; // 1) DARE AL NUOVO OGGETTO LE STESSE PROPRIETA' DEL PADRE
			// 2) 
			newPec.AddComponent<MeshCollider>();
			//go.AddComponent<MyCustomScript>();
		}
	}
}
