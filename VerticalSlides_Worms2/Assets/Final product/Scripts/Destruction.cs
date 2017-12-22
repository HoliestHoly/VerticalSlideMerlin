                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour 
{
	PolygonCollider2D col;
	Texture2D text2D;
	SpriteRenderer sprRenderer;

	void Start()
	{
		// copy all pixels of the original sprite
		var sprite = GetComponent<SpriteRenderer>().sprite.texture;
		text2D = new Texture2D (sprite.width, sprite.height);
		text2D.SetPixels32 (sprite.GetPixels32 ());
		sprRenderer = GetComponent<SpriteRenderer> ();
		text2D.Apply ();
		sprRenderer.sprite = Sprite.Create (text2D, new Rect (0, 0, text2D.width, text2D.height), new Vector2(0.5f, 0.5f));
		col = gameObject.AddComponent <PolygonCollider2D> ();
		Explosion (200, 200, 150);

	}

	public void Explosion(int m1, int m2, int radius)
	{
		Destroy (col);
		int r2 = radius * radius;
		List<Point> vec = new List<Point> ();
		for (int x = 0; x < text2D.width; x++) {
			for (int y = 0; y < text2D.height; y++) {
				int dx = x - m1;
				int dy = y - m2;
				int ds = dx * dx + dy * dy;

				if (ds <= r2) {
					vec.Add (new Point (x, y));
				}
			}
		}

		foreach (var pos in vec) {
			text2D.SetPixel (pos.x, pos.y, new Color (0, 0, 0, 0));
		}
		text2D.Apply();

		sprRenderer.sprite = Sprite.Create (text2D, sprRenderer.sprite.rect, new Vector2(0.5f, 0.5f), sprRenderer.sprite.pixelsPerUnit);

		col = gameObject.AddComponent <PolygonCollider2D> ();

	}
	void Update(){

	}

	struct Point
	{
		public int x;
		public int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}


}