Example scene has:

Parent (scale 1) -> Middle (scale 0.2) -> Cube (scale 0.6)

There is a script on Parent that rotates it a little on the Y axis each frame.

Cube has a script that prints the value of BoxCollider.size.x and transform.TransformVector(BoxCollider.size.x) each frame.

If Middle is removed, then there is a fixed ratio between those two numbers and they will be consistent as Parent rotates.

However, if Middle is left as-is, the ratio between BoxCollider.size.x and transform.TransformVector(BoxCollider.size.x) changes as Parent rotates. I'd like to figure out how to avoid this.
