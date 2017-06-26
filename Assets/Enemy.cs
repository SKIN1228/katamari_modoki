﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
	private float speed = 1f;
	private float rotationSmooth = 1f;

	private Transform player;

	private void Start()
	{
		// 始めにプレイヤーの位置を取得できるようにする
		player = GameObject.FindWithTag("Player").transform;
	}

	private void Update()
	{
		// プレイヤーの方向を向く
		Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

		// 前方に進む
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}