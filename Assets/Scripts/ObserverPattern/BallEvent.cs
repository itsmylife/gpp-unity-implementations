public abstract class BallEvent {
    public abstract float GetJumpForce();
}


public class JumpLittle : BallEvent {
    public override float GetJumpForce() {
        return 10f;
    }
}


public class JumpMedium : BallEvent {
    public override float GetJumpForce() {
        return 20f;
    }
}


public class JumpHigh : BallEvent {
    public override float GetJumpForce() {
        return 30f;
    }
}