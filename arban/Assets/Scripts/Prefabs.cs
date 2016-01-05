﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Prefabs : MonoBehaviour {
	public GameObject skyscraper1;
	public GameObject tree1;
	public GameObject general4;
	public GameObject general7;
	public GameObject general12;
	public GameObject general33;
	public GameObject general41;
	public GameObject general46;

	public GameObject getPrefab(string name) {
		GameObject prefab;

		if (name == "skyscraper1") prefab = skyscraper1;
		else if (name == "tree1") prefab = tree1;
		else if (name == "general4") prefab = general4;
		else if (name == "general7") prefab = general7;
		else if (name == "general12") prefab = general12;
		else if (name == "general33") prefab = general33;
		else if (name == "general41") prefab = general41;
		else if (name == "general46") prefab = general46;
		else prefab = null;

		return prefab;
	}
}