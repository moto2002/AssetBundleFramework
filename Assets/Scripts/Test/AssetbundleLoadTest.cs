﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AssetbundleLoadTest : MonoBehaviour {

	private string _assetbundlePath = "";

	// Use this for initialization
	void Start () {
	}

	void LoadAssetbundleDependcy()
	{

	}

	// Update is called once per frame
	void Update () {

	}

	private string _prefabName = "";
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2-100,200,200),"LoadScene"))
		{
			SceneManager.LoadScene("scene1");
		}
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2+100,200,200),"LoadPrefab"))
		{
			if(!string.IsNullOrEmpty(_prefabName))
			{
				string prefabName = "Prefabs/" + _prefabName;
				Debug.Log("prefabName  is " + prefabName);
				SimpleLoader.InstantiateGameObject(prefabName);
			}
		}
		_prefabName = GUI.TextField(new Rect(Screen.width-200,10,200,200),_prefabName);

	}
}