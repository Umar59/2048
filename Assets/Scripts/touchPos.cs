using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchPos : MonoBehaviour
{
	public Touch touch = new Touch();
  
	void Update()
	{
		if (Input.touchCount > 0)
		{
			touch = Input.GetTouch(0);
		}

	}
	
}
