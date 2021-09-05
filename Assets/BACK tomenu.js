var isbacktomenu = false;

function OnMouseEnter()
{
renderer.material.color = Color.gray;
}
function OnMouseExit()
{
renderer.material.color = Color.white;
}

function OnMouseUp()
{

if ( isbacktomenu )

{
Application.LoadLevel(0);
}
}