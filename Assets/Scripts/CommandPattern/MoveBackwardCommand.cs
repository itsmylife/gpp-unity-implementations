using System;
using UnityEngine;

public class MoveBackwardCommand : Command {
	public override void Execute(Moveable actor) {
		actor.moveBackward();
	}

	public override void Undo(Moveable actor) {
		actor.moveForward();
	}
}


