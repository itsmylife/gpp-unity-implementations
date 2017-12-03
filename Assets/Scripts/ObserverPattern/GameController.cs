using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Agent;

    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;

    public Messenger messenger = new Messenger();

    // For best example of this pattern is 
    // StrangeIoC https://strangeioc.github.io/strangeioc/
    // Zenject https://github.com/modesttree/Zenject
    void Start() {
        var ballObserver1 = new Ball(Ball1, new JumpHigh());
        var ballObserver2 = new Ball(Ball2, new JumpLittle());
        var ballObserver3 = new Ball(Ball3, new JumpMedium());

        messenger.AddObserver(ballObserver1);
        messenger.AddObserver(ballObserver2);
        messenger.AddObserver(ballObserver3);
    }

    // Update is called once per frame
    void Update() {
        //The boxes should jump if the sphere is cose to origo
        if ((Agent.transform.position).magnitude < 1f) {
            messenger.Notify();
        }
    }
}