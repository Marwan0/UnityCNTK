﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityCNTK{
	public class CNTKManager : MonoBehaviour {
		public static CNTKManager instance;
		public List<StreamingModel<IConvertible, IConvertible>> managedModels = new List<StreamingModel<IConvertible, IConvertible>>();
		
		void Start () {
			MakeSingleton();
		}
		
		// Update is called once per frame
		void Update () {
			
		}


		private void MakeSingleton()
		{
			if (instance != null && instance != this )
			{	
				Debug.LogError("Only 1 CNTK manager allowed in a scene, destroying");
				Destroy(this);
			}
			else
			{
				instance = this;
			}
		}
	}

}
