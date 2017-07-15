using System;
using UnityEngine;

public class MoveRightCommand : Command {
	public override void Execute(Moveable actor) {
		actor.moveRight();
	}

	public override void Undo(Moveable actor) {
		actor.moveLeft();
	}
}

