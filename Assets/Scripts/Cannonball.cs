using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cannonball : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Rigidbody cannonBallRB;
    public bool isShooting = false;	
	[SerializeField] MousePos touchPos;
	public bool isReset = true;

	void Update()
	{
		if (isReset)
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);
				switch (touch.phase)
				{
					case TouchPhase.Began:

						target.SetActive(true);

						isShooting = false;

						break;

					case TouchPhase.Ended:

						
                        if (target.activeSelf)
                        {
							target.SetActive(false);
							isShooting = true;
							Debug.Log("true");
							Shoot();
						}
						

						break;

				}
			}
		}

	}

	public void Shoot()
    {    
            cannonBallRB.isKinematic = false;
            cannonBallRB.AddForce((target.transform.position - transform.position).normalized * 12500);
			isReset = false;
    }
    public void ResetPosition()
    {
        cannonBallRB.isKinematic = true;
        transform.position = new Vector3(0.31f, 7.88f, 9.62f);
        isReset = true;
    }
}
