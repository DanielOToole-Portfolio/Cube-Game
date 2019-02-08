#pragma strict


static var currentScore : int = 0;
var test = 0;
function Update(){
	test = currentScore;

}




function OnGUI () {

	GUI.Box (Rect (10, 10, 100, 20) , ("Coins" + " " + currentScore));


}
