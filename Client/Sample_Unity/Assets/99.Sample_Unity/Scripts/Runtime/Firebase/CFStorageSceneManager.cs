using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Firebase {
	/** 저장소 씬 관리자 */
	public partial class CFStorageSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_F_STORAGE;
		#endregion         // 프로퍼티                 
	}
}
