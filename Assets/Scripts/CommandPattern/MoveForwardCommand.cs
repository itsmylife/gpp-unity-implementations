using System;
using UnityEngine;

public class MoveForwardCommand : Command {
	public override void Execute(Moveable actor) {
		actor.moveForward();
	}

	public override void Undo(Moveable actor) {
		actor.moveBackward();
	}
}

