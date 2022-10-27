using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
using System.IO;
using System.Linq;

namespace Google {
	/** 구글 시트 씬 관리자 */
	public partial class CGGoogleSheetSceneManager : StudyScene.CSSceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_G_GOOGLE_SHEET;
		#endregion          // 프로퍼티                 

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
				this.UIs.ExFindComponent<Button>("LOAD_GOOGLE_SHEET_BTN")?.onClick.AddListener(this.OnTouchLoadGoogleSheetBtn);
				this.UIs.ExFindComponent<Button>("SAVE_GOOGLE_SHEET_BTN")?.onClick.AddListener(this.OnTouchSaveGoogleSheetBtn);
			}
		}

		/** 구글 시트 로드 버튼을 눌렀을 경우 */
		private void OnTouchLoadGoogleSheetBtn() {
#if GOOGLE_SHEET_ENABLE
			string oKey = Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_VER_INFO);
			Func.LoadVerInfoGoogleSheet(KDefine.G_ID_GOOGLE_SHEET_DICT.GetValueOrDefault(oKey), this.OnLoadVerInfoGoogleSheet);
#endif            // #if GOOGLE_SHEET_ENABLE                                    
		}

		/** 구글 시트 저장 버튼을 눌렀을 경우 */
		private void OnTouchSaveGoogleSheetBtn() {
#if GOOGLE_SHEET_ENABLE

#endif            // #if GOOGLE_SHEET_ENABLE                                    
		}
		#endregion         // 함수               

		#region 조건부 함수
#if GOOGLE_SHEET_ENABLE
		/** 구글 시트가 로드 되었을 경우 */
		private void OnLoadGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			CFunc.ShowLog($"CGGoogleSheetSceneManager.OnLoadGoogleSheet: {a_stGoogleSheetLoadInfo.m_oID}, {a_stGoogleSheetLoadInfo.m_oName}, {a_oJSONNodeInfoDict.ExToJSONNode()}");

			// 로드 되었을 경우
			if(a_bIsSuccess) {
				var oHandlerDict = new Dictionary<string, System.Action>() {
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ETC_INFO)] = () => CEtcInfoTable.Inst.SaveEtcInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_MISSION_INFO)] = () => CMissionInfoTable.Inst.SaveMissionInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_REWARD_INFO)] = () => CRewardInfoTable.Inst.SaveRewardInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_RES_INFO)] = () => CResInfoTable.Inst.SaveResInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ITEM_INFO)] = () => CItemInfoTable.Inst.SaveItemInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_SKILL_INFO)] = () => CSkillInfoTable.Inst.SaveSkillInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_OBJ_INFO)] = () => CObjInfoTable.Inst.SaveObjInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ABILITY_INFO)] = () => CAbilityInfoTable.Inst.SaveAbilityInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString()),
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_PRODUCT_INFO)] = () => CProductTradeInfoTable.Inst.SaveProductTradeInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString())
				};

				oHandlerDict.GetValueOrDefault(a_stGoogleSheetLoadInfo.m_oName)?.Invoke();
			}
		}

		/** 구글 시트가 로드 되었을 경우 */
		private void OnLoadGoogleSheets(CServicesManager a_oSender, bool a_bIsSuccess) {
			Func.ShowAlertPopup($"CGGoogleSheetSceneManager.OnLoadGoogleSheets: {a_bIsSuccess}", null, false);
		}

		/** 버전 정보 구글 시트를 로드했을 경우 */
		private void OnLoadVerInfoGoogleSheet(CServicesManager a_oSender, SimpleJSON.JSONNode a_oVerInfos, Dictionary<string, STGoogleSheetInfo> a_oGoogleSheetInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				Func.LoadGoogleSheets(a_oGoogleSheetInfoDict.Values.ToList(), new Dictionary<string, System.Action<CServicesManager, STGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode>, bool>>() {
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ETC_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_MISSION_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_REWARD_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_RES_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ITEM_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_SKILL_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_OBJ_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_ABILITY_INFO)] = this.OnLoadGoogleSheet,
					[Path.GetFileNameWithoutExtension(KCDefine.U_TABLE_P_G_PRODUCT_INFO)] = this.OnLoadGoogleSheet,
				}, this.OnLoadGoogleSheets);
			} else {
				Func.ShowAlertPopup($"CGGoogleSheetSceneManager.OnLoadVerInfoGoogleSheet: {a_bIsSuccess}", null);
			}
		}
#endif         // #if GOOGLE_SHEET_ENABLE                                    
		#endregion         // 조건부 함수                   
	}
}
#endif          // #if EXTRA_SCRIPT_MODULE_ENABLE
