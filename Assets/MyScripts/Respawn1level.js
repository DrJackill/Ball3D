var startX : float;
var startY : float;
var startZ : float;

function Update ()
{
	//check if you character fell off the platform
	if(transform.position.y < -10)
	{
		transform.position.y = startY;
		transform.position.x = startX;
		transform.position.z = startZ;
	}		
}