private var obj1:GameObject;
private var obj2:GameObject;
private var timer:float;

function Start (){
    obj1 = GameObject.FindWithTag("Beam");
    obj1.gameObject.SetActive(false);
}

function Update () {
	if(timer < 2){
		if (Input.GetKeyDown ("space")){
     		obj1.gameObject.SetActive(true);
     		timer += Time.deltaTime;
		}
	}
}