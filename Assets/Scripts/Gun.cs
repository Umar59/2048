using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

	public Cannonball ball;
	[SerializeField] MousePos touchPos;
	[SerializeField] private GameObject aim;
	private Ray ray;
	void Update()
	{
		if (ball.isShooting == false)
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);

				switch (touch.phase)
				{
					case TouchPhase.Began:

						aim.SetActive(true);

						ball.isShooting = false;

						break;

					case TouchPhase.Ended:

						aim.SetActive(false);

						ball.isShooting = true;
						ball.Shoot();

						break;

				}
			}
		}

	}

}

