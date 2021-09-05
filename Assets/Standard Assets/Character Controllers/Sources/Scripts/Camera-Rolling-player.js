/*
This camera smoothes out rotation around the y-axis and height for objects that roll which makes it difficult to just use the forward Vector.
Horizontal Distance to the target is always fixed.

There are many different ways to smooth the rotation but doing it this way gives you a lot of control over how the camera behaves.

For every of those smoothed values we calculate the wanted value and the current value.
Then we smooth it using the Lerp function.
Then we apply the smoothed values to the transform's position.
*/

// The target we are following
var target : Transform;
var targetRB : Rigidbody;

// The distance in the x-z plane to the target
var distance = 10.0;
// the height we want the camera to be above the target
var height = 5.0;
// How much we 
var heightDamping = 2.0;
var rotationDamping = 3.0;
private var rotationAngle = 0;
// Place the script in the Camera-Control group in the component menu
@script AddComponentMenu("Camera-Control/Smooth Follow")


function LateUpdate () {
    // Early out if we don't have a target
    if (!target || !targetRB)
        return;

    //Take the target's velocity, remove the y and normalize it.  The final step is probably unneeded but makes it easier to extend.
//    var direction = targetRB.velocity;
//    direction.y = 0;
//    direction = direction.normalized;
//
//    //Get the desired rotation from the ball's velocity.
//    var wantedRotation : Quaternion = Quaternion.LookRotation(direction); 
//    wantedRotationAngle = wantedRotation.eulerAngles.y;
    var wantedHeight = target.position.y + height;
//
//    //Our current rotation is the ball's position minus our own.    
//    var currentRotation : Quaternion = Quaternion.LookRotation(target.position - transform.position);   
//    currentRotationAngle = currentRotation.eulerAngles.y;
    var currentHeight = transform.position.y;
//
//    // Damp the rotation around the y-axis
//    currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

    // Damp the height
    currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);

    // Convert the angle into a rotation
    //if(Input.GetMouseButton(0))
    rotationAngle=rotationAngle+Input.GetAxis("Rotation");
//    else {
//    //rotationAngle=0;
//    //Input.GetAxis("Rotation")=0;
//    //Screen.lockCursor = true;
//    Input.ResetInputAxes();
//    }
    var finalRotation = Quaternion.Euler (0,rotationAngle,0);//currentRotationAngle, 0);



    // Set the position of the camera on the x-z plane to:
    // distance meters behind the target
    transform.position = target.position;
    transform.position -= finalRotation * Vector3.forward * distance;

    // Set the height of the camera
    transform.position.y = currentHeight;

    // Always look at the target
    transform.LookAt (target);
}