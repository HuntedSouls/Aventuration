using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{

	float EndAngle = 0;

    // Start is called before the first frame update
    void Start()
    {

		SetNextRotation();
    }

    // Update is called once per frame
    void Update()
    {
		float angle = Mathf.LerpAngle(transform.eulerAngles.z, EndAngle, Time.deltaTime);
		transform.eulerAngles = new Vector3(0, 0, angle);

		if (Mathf.Round(transform.eulerAngles.z) == EndAngle) {
			SetNextRotation();
		}
    }

	void SetNextRotation() {
		EndAngle = Random.Range(-5,5);
		if (EndAngle<0) {
			EndAngle = 360 - Mathf.Abs(EndAngle);
		}
	}
}
