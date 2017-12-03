using System.Collections.Generic;

public class Messenger {
    // Not the best solution 
    private List<Observer> observers = new List<Observer>();

    public void Notify() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].OnNotify();
        }
    }

    public void AddObserver(Observer newObserver) {
        // Not the best solution 
        if (observers.IndexOf(newObserver) == -1) {
            observers.Add(newObserver);
        }
    }

    public void RemoveObserver(Observer existingObserver) {
        // Not the best solution 
        if (observers.IndexOf(existingObserver) != -1) {
            observers.Add(existingObserver);
        }
    }
}