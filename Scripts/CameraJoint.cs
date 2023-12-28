using Godot;

public partial class CameraJoint : SpringArm3D
{
  public override void _Ready()
  {
    var rotation = RotationDegrees;
    rotation.X = -45f;

    RotationDegrees = rotation;
  }
}
