using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPattern : MonoBehaviour {
	public Moveable Box;

	Stack<Command> undoCommands = new Stack<Command>();
	Stack<Command> redoCommands = new Stack<Command>();

	void Update() {
		HandleInput();
	}

	void HandleInput() {
		Command command = null;

		if (Input.GetKeyDown(KeyCode.W)) {
			command = new MoveForwardCommand();
		} else if (Input.GetKeyDown(KeyCode.S)) {
			command = new MoveBackwardCommand();
		} else if (Input.GetKeyDown(KeyCode.A)) {
			command = new MoveLeftCommand();
		} else if (Input.GetKeyDown(KeyCode.D)) {
			command = new MoveRightCommand();
		} else if (Input.GetKeyDown(KeyCode.Z)) {
			Undo();
		} else if (Input.GetKeyDown(KeyCode.R)) {
			Redo();
		}

		if (command != null) {
			undoCommands.Push(command);
			command.Execute(Box);
		}
	}

	private void Undo() {
		if (undoCommands.Count > 0) {
			Command command = undoCommands.Pop();
			redoCommands.Push(command);
			command.Undo(Box);
		} else {
			return;
		}
	}

	private void Redo() {
		if (redoCommands.Count > 0) {
			Command command = redoCommands.Pop();
			undoCommands.Push(command);
			command.Execute(Box);
		} else {
			return;
		}
	}
}
