﻿using UnityEditor;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
	public float speed = 5;
	public bool instant;

	private Camera m_MainCamera;

	private void Start()
	{
		m_MainCamera = Camera.main;
	}

	private void Update()
	{
		Vector2 mouseDirection = m_MainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float mouseAngle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;
		Quaternion desiredRotation = Quaternion.AngleAxis(mouseAngle, Vector3.forward);

		if (instant)
		{
			transform.rotation = desiredRotation;
		}
		else
		{
			transform.rotation = Quaternion.RotateTowards(
				transform.rotation,
				desiredRotation,
				speed * Time.deltaTime * Mathf.Rad2Deg
			);
		}
	}
}


