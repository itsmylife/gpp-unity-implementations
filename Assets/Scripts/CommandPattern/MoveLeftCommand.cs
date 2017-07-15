using System;
using UnityEngine;

public class MoveLeftCommand : Command {
	public override void Execute(Moveable actor) {
		actor.moveLeft();
	}

	public override void Undo(Moveable actor) {
		actor.moveRight();
	}
}

