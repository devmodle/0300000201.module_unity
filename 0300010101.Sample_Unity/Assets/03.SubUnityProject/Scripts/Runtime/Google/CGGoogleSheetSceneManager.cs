using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Google {
	/** 구글 시트 씬 관리자 */
	public partial class CGGoogleSheetSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_GOOGLE_SHEET;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if GOOGLE_SHEET_ENABLE

#endif			// #if GOOGLE_SHEET_ENABLE
			}
		}
		#endregion			// 함수
	}
}
