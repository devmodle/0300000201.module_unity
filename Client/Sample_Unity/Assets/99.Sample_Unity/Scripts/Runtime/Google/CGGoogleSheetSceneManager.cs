using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
using System.Linq;

namespace Google {
	/** 구글 시트 씬 관리자 */
	public partial class CGGoogleSheetSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_GOOGLE_SHEET;
		#endregion // 프로퍼티                 

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("LOAD_GOOGLE_SHEET_BTN")?.onClick.AddListener(() => {
#if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
					string oKey = KCDefine.U_TABLE_P_G_VER_INFO.ExGetFileName(false);
					Func.LoadVerInfoGoogleSheet(KDefine.G_TABLE_INFO_GOOGLE_SHEET_DICT.GetValueOrDefault(oKey).m_oID, this.OnLoadVerInfoGoogleSheet);
#endif // #if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
				});

				this.UIs.ExFindComponent<Button>("SAVE_GOOGLE_SHEET_BTN")?.onClick.AddListener(() => {
#if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
					Func.SaveGoogleSheets(new Dictionary<string, System.Action<CServicesManager, STGoogleSheetSaveInfo, bool>>() {
						[KCDefine.U_TABLE_P_G_ETC_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_MISSION_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_REWARD_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_RES_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_ITEM_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_SKILL_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_OBJ_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_ABILITY_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
						[KCDefine.U_TABLE_P_G_PRODUCT_INFO.ExGetFileName(false)] = this.OnSaveGoogleSheet,
					}, this.OnSaveGoogleSheets);
#endif // #if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
				});
			}
		}
		#endregion // 함수               

		#region 조건부 함수
#if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
		/** 구글 시트를 로드했을 경우 */
		private void OnLoadGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			CFunc.ShowLog($"CGGoogleSheetSceneManager.OnLoadGoogleSheet: {a_stGoogleSheetLoadInfo.m_oID}, {a_stGoogleSheetLoadInfo.m_oSheetName}, {a_oJSONNodeInfoDict.ExToJSONNode()}");

			// 로드 되었을 경우
			if(a_bIsSuccess) {
				var oHandlerDict = new Dictionary<string, System.Action>() {
					[KCDefine.U_TABLE_P_G_ETC_INFO.ExGetFileName(false)] = () => CEtcInfoTable.Inst.SaveEtcInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_MISSION_INFO.ExGetFileName(false)] = () => CMissionInfoTable.Inst.SaveMissionInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_REWARD_INFO.ExGetFileName(false)] = () => CRewardInfoTable.Inst.SaveRewardInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_RES_INFO.ExGetFileName(false)] = () => CResInfoTable.Inst.SaveResInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_ITEM_INFO.ExGetFileName(false)] = () => CItemInfoTable.Inst.SaveItemInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_SKILL_INFO.ExGetFileName(false)] = () => CSkillInfoTable.Inst.SaveSkillInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_OBJ_INFO.ExGetFileName(false)] = () => CObjInfoTable.Inst.SaveObjInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_ABILITY_INFO.ExGetFileName(false)] = () => CAbilityInfoTable.Inst.SaveAbilityInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[KCDefine.U_TABLE_P_G_PRODUCT_INFO.ExGetFileName(false)] = () => CProductTradeInfoTable.Inst.SaveProductTradeInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString())
				};

				oHandlerDict.GetValueOrDefault(a_stGoogleSheetLoadInfo.m_oSheetName)?.Invoke();
			}
		}

		/** 구글 시트를 로드했을 경우 */
		private void OnLoadGoogleSheets(CServicesManager a_oSender, bool a_bIsSuccess) {
			Func.ShowAlertPopup($"CGGoogleSheetSceneManager.OnLoadGoogleSheets: {a_bIsSuccess}", null, false);
		}

		/** 버전 정보 구글 시트를 로드했을 경우 */
		private void OnLoadVerInfoGoogleSheet(CServicesManager a_oSender, SimpleJSON.JSONNode a_oVerInfos, Dictionary<string, STLoadGoogleSheetInfo> a_oLoadGoogleSheetInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				Func.LoadGoogleSheets(a_oLoadGoogleSheetInfoDict.Values.ToList(), new Dictionary<string, System.Action<CServicesManager, STGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode>, bool>>() {
					[KCDefine.U_TABLE_P_G_ETC_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_MISSION_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_REWARD_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_RES_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_ITEM_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_SKILL_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_OBJ_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_ABILITY_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
					[KCDefine.U_TABLE_P_G_PRODUCT_INFO.ExGetFileName(false)] = this.OnLoadGoogleSheet,
				}, this.OnLoadGoogleSheets);
			} else {
				Func.ShowAlertPopup($"CGGoogleSheetSceneManager.OnLoadVerInfoGoogleSheet: {a_bIsSuccess}", null, false);
			}
		}

		/** 구글 시트를 저장했을 경우 */
		private void OnSaveGoogleSheet(CServicesManager a_oSender, STGoogleSheetSaveInfo a_stGoogleSheetSaveInfo, bool a_bIsSuccess) {
			CFunc.ShowLog($"CGGoogleSheetSceneManager.OnLoadGoogleSheet: {a_stGoogleSheetSaveInfo.m_oID}, {a_stGoogleSheetSaveInfo.m_oSheetName}");
		}

		/** 구글 시트를 저장했을 경우 */
		private void OnSaveGoogleSheets(CServicesManager a_oSender, bool a_bIsSuccess) {
			Func.ShowAlertPopup($"CGGoogleSheetSceneManager.OnSaveGoogleSheets: {a_bIsSuccess}", null, false);
		}
#endif // #if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
		#endregion // 조건부 함수                   
	}
}
#endif // #if EXTRA_SCRIPT_MODULE_ENABLE
