using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGScroller : MonoBehaviour {

	[Header("Velocidad de Movimiento:")]
	public float scrollSpeed;

	[Header("Tamaño del fondo en unidades:")]
	public float bgSize;

	[Header("Dirección para mover el fondo:")]
	public Vector3 direccion;
	
	private Scene escena;
	private Vector3 startPosition;
	private bool moveAlways;

	void Start ()
	{
		moveAlways = true;
		startPosition = transform.position;
		direccion.Normalize ();
	}

	void Update ()
	{
		if (moveAlways) {
			float newPosition = Mathf.Repeat (Time.time * scrollSpeed, bgSize);
			transform.position = startPosition + direccion * newPosition;
		}
		else{
			
		}	
	}
}
