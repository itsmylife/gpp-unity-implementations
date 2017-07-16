using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFactory {
	private bool useflyweightPattern;

	private Sprite sampleSprite;
	private Texture2D sampleTexture;

	public SpriteFactory(bool useFlyweight) {
		useflyweightPattern = useFlyweight;
	}

	public Sprite getSprite() {
		if (sampleSprite == null || !useflyweightPattern) {
			sampleTexture = createTexture();	
			sampleSprite = Sprite.Create(sampleTexture, new Rect(0.0f, 0.0f, sampleTexture.width, sampleTexture.height), new Vector2(0.5f, 0.5f), 100.0f);
		}

		return sampleSprite;
	}

	Texture2D createTexture() {
		var texture = new Texture2D(16, 16, TextureFormat.ARGB32, false);

		texture.SetPixel(0, 0, new Color(1.0f, 1.0f, 1.0f, 0.5f));
		texture.SetPixel(1, 0, Color.clear);
		texture.SetPixel(0, 1, Color.white);
		texture.SetPixel(1, 1, Color.black);

		texture.Apply();

		return texture;
	}
}
