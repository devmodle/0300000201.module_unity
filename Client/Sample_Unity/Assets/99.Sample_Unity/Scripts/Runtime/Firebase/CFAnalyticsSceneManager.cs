using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Firebase {
	/** 분석 씬 관리자 */
	public partial class CFAnalyticsSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_F_ANALYTICS;
		#endregion         // 프로퍼티                 
	}
}
