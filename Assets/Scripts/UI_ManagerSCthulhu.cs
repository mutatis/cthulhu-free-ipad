﻿using UnityEngine;
using System.Collections;

public class UI_ManagerSCthulhu : MonoBehaviour {

	public int value;
	public GameObject valor;
	public GameObject cash;
	
	void Start ()
	{
		if (PlayerPrefs.GetInt("hasSCthulhu") == 1)
		{
			valor.SetActive(false);
			cash.SetActive(false);
		}
	}
}