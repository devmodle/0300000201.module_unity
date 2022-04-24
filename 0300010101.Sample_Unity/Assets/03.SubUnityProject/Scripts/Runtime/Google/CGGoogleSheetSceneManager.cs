using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_ENABLE
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
#if (UNITY_STANDALONE && GOOGLE_SHEET_ENABLE) && (DEBUG || DEVELOPMENT_BUILD)
				this.ScrollViewContents.ExFindComponent<Button>("LoadGoogleSheetBtn").onClick.AddListener(() => {
					Func.LoadGoogleSheet("1USlBUOWpGUR97lRSaxI8BpNtTyygqzbd11MGYFSSRZs", new List<(string, int)>() { ("Level", 2) }, (a_oSender, a_oGooleSheet, a_oID, a_oJSONNodeInfoDict) => {
						foreach(var stKeyVal in a_oJSONNodeInfoDict) {
							CFunc.ShowLog($"LoadGoogleSheet: {stKeyVal.Key}, {stKeyVal.Value.Item1.ToString()}, {stKeyVal.Value.Item2}");
						}
					});
				});
#endif			// #if (UNITY_STANDALONE && GOOGLE_SHEET_ENABLE) && (DEBUG || DEVELOPMENT_BUILD)
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_ENABLE
