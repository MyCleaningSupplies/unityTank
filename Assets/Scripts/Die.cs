using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
	public int lives;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		print ("what hit me?" + coll.gameObject.name);
		if(coll.gameObject.name == "Bullit(Clone)")
		{
			lives--;
			if(lives <= 0)
			{
				Destroy(this.gameObject);
			}
		}

	}
}
