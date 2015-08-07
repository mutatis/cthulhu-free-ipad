﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_BuyMoon : MonoBehaviour {

	public int value;
	private string originalText;
	public GameObject select;
	public GameObject valor;
	public AudioClip[] botao;
	
	void Start ()
	{
		if (PlayerPrefs.GetInt("hasMoon") == 1)
		{
			valor.SetActive(false);
			select.SetActive(true);
			gameObject.SetActive(false);
		}
	}
	
	public void EnableHasMoon ()
	{
		if(GameManager.totalCoins >= value)
		{
			PlayerPrefs.SetInt("hasMoon", 1);
			GameManager.Buy(value);
			GameManager.gameManager.hasMoon = true;
			AudioSource.PlayClipAtPoint(botao[0], transform.position, 1f);
			select.SetActive(true);
			valor.SetActive(false);
			gameObject.SetActive(false);
		}
		else
		{
			AudioSource.PlayClipAtPoint(botao[1], transform.position, 1f);
		}
	}
}