using System;
using UnityEngine;

public abstract class Command
{
	public abstract void Execute(Moveable actor);

	public abstract void Undo(Moveable actor);
}
