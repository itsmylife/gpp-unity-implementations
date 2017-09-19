using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightPattern : MonoBehaviour {
	
//	Please check the draw call count on Stats window 
//	and memory consumption from Profiler panel 	
	

	List<Cell> cellList;
	SpriteFactory spriteFactory;

	public bool useFlyweight;

	void Start() {
		cellList = new List<Cell>();
		spriteFactory = new SpriteFactory(useFlyweight);
		Cell cell;
		for (int i = 0; i < 10000; i++) {
			cell = new Cell(spriteFactory);
			cell.ChangeColor(Random.ColorHSV());
			cellList.Add(cell);
		}
	}

}
