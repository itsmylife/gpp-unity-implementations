using UnityEngine;

public class Ball : Observer {
    private readonly GameObject _ball;
    private readonly BallEvent _ballEvent;

    public Ball(GameObject ball, BallEvent ballEvent) {
        _ball = ball;
        _ballEvent = ballEvent;
    }

    public override void OnNotify() {
        Jump(_ballEvent.GetJumpForce());
    }

    //The box will always jump in this case
    void Jump(float jumpForce) {
        //If the box is close to the ground
        if (_ball.transform.position.y < 0.55f) {
            _ball.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}