using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {
	private Transform[] transforms;
	protected Transform Turret;
	protected Transform nozzle;
	protected Vector3 targetPos;
	// Use this for initialization


	virtual protected void Start () {

		bool turretFound = false;
		transforms = gameObject.GetComponentsInChildren<Transform>();
		foreach(Transform t in transforms)
		{
			print(t.name);
			if (t.gameObject.name == "Turret") 
			{
				
				Turret = t;
				turretFound = true;
			}
			if(t.gameObject.name ==  "nozzle")
			{
				nozzle = t;
			}
		}
		if (!turretFound) {
			print ("no turret was found in the gameobject");
		}
	
	}
	
	// Update is called once per frame
	 protected virtual void Update () {

		Turret.LookAt(targetPos);
	
	}
}
