using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
using System.IO;

namespace Etc {
	/** 구글 씬 관리자 */
	public class CEGoogleSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_GOOGLE;
		#endregion          // 프로퍼티                 

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("LOAD_GOOGLE_SHEET_BTN")?.onClick.AddListener(this.OnTouchLoadGoogleSheetBtn);
			}
		}

		/** 구글 시트 로드 버튼을 눌렀을 경우 */
		private void OnTouchLoadGoogleSheetBtn() {
#if GOOGLE_SHEET_ENABLE
			string oKey = Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_VER_INFO);

			Func.LoadVerInfoGoogleSheet(KDefine.G_ID_GOOGLE_SHEET_DICT.GetValueOrDefault(oKey), new Dictionary<string, System.Action<CServicesManager, STGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode>, bool>>() {
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ETC_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_MISSION_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_REWARD_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_RES_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ITEM_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_SKILL_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_OBJ_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ABILITY_INFO)] = this.OnLoadGoogleSheet,
				[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_PRODUCT_INFO)] = this.OnLoadGoogleSheet,
			}, this.OnLoadVerInfoGoogleSheet);
#endif            // #if GOOGLE_SHEET_ENABLE                                    
		}
		#endregion         // 함수               

		#region 조건부 함수
#if GOOGLE_SHEET_ENABLE
		/** 구글 시트가 로드 되었을 경우 */
		private void OnLoadGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			CFunc.ShowLog($"CEGoogleSceneManager.OnLoadGoogleSheet: {a_stGoogleSheetLoadInfo.m_oID}, {a_stGoogleSheetLoadInfo.m_oName}, {a_oJSONNodeInfoDict.ExToJSONNode()}");
		}

		/** 구글 시트가 로드 되었을 경우 */
		private void OnLoadGoogleSheets(CServicesManager a_oSender, bool a_bIsSuccess) {
			Func.ShowAlertPopup($"CEGoogleSceneManager.OnLoadGoogleSheets: {a_bIsSuccess}", null);
		}

		/** 버전 정보 구글 시트를 로드했을 경우 */
		private void OnLoadVerInfoGoogleSheet(CServicesManager a_oSender, SimpleJSON.JSONNode a_oVerInfos, Dictionary<string, STGoogleSheetInfo> a_oGoogleSheetInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				Func.LoadGoogleSheets(a_oGoogleSheetInfoDict.ExToList(), this.OnLoadGoogleSheets);
			} else {
				Func.ShowAlertPopup($"CEGoogleSceneManager.OnLoadVerInfoGoogleSheet: {a_bIsSuccess}", null);
			}
		}
#endif         // #if GOOGLE_SHEET_ENABLE                                    
		#endregion         // 조건부 함수                   
	}
}
#endif          // #if EXTRA_SCRIPT_MODULE_ENABLE
