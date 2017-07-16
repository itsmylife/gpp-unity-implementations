using System;
using UnityEngine;

public class Cell {
	private SpriteFactory _factory;
	private GameObject gameObject;

	public Cell(SpriteFactory factory) {
		_factory = factory;
		gameObject = new GameObject("New Cell " + UnityEngine.Random.Range(0, 100000));
		gameObject.transform.position = new Vector3(
			UnityEngine.Random.Range(0, 10),
			UnityEngine.Random.Range(0, 10),
			0
		);
		SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;

		sr.sprite = _factory.getSprite();
	}

	public void ChangeColor(Color color) {
		// color change.
	}
}


