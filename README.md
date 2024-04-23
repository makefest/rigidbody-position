# rigidbody-position
testing Unity's Rigidbody API

Below video shows a scene with three different test cases.

In all three cases, on the cube there is a `Rigidbody` and a custom `ResetPosition` component.

`ResetPosition` stores the initial position of `Rigidbody`:

https://github.com/makefest/rigidbody-position/blob/c5eff1a0ba450ea926d7c241310942af629e84c9/RigidbodyPosition/Assets/Scripts/ResetPosition.cs#L11-L16

Below the cubes there are trigger colliders and `ResetPosition` resets the position upon collision, either using `Rigidbody.position` (case 2) or `Transform.position` (case 3):

https://github.com/makefest/rigidbody-position/blob/c5eff1a0ba450ea926d7c241310942af629e84c9/RigidbodyPosition/Assets/Scripts/ResetPosition.cs#L26-L34

Method `ZeroVelocityOnRigidbodies()` is just to prevent accumulating velocity.

In case 2 and 3, the cube also has a `ConfigurableJoint` with the child sphere as the connected body and motion constrained to the y axis.

As the video shows, in case 2 where the cube position is reset using `Reset.position`, the cube does not get back to its original position but somewhere in between.

https://github.com/makefest/rigidbody-position/assets/64745050/5aff105d-4813-48bf-aef9-5da7afe9294b
