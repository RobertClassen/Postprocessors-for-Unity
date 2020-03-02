﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LangVersion
{
	#region Fields
	[SerializeField]
	private string name;
	[SerializeField]
	private string description;
	#endregion

	#region Properties
	public string Name
	{
		get
		{
			return name;
		}
	}

	public string Description
	{
		get
		{
			return description;
		}
	}
	#endregion

	#region Constructor
	
	#endregion

	#region Methods
	
	#endregion
}