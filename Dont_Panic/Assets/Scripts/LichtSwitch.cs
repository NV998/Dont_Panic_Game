using UnityEngine;
using System.Collections;

public class LichtSwitch : MonoBehaviour {

	public GameObject lichtje1;
	public GameObject lichtje2;
	bool knopje;

	void Update(){
		if(knopje){
			lichtje1.SetActive (false);
			lichtje2.SetActive (false);
		}
		else{
			lichtje1.SetActive (true);
			lichtje2.SetActive (true);
		}

		if (Input.GetKeyDown(KeyCode.F))
		{
			knopje = !knopje;
		}
	}
}