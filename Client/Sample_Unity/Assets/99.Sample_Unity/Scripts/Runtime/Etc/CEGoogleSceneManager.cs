using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if EXTRA_SCRIPT_MODULE_ENABLE
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
			//Func.LoadVerInfoGoogleSheet("11lBz0haEcQDRfOcxW-V-CbtD15Go_7Z22CA3qOTtGps", new Dictionary<
#endif            // #if GOOGLE_SHEET_ENABLE                                    
		}
		#endregion         // 함수               

		#region 조건부 함수
#if GOOGLE_SHEET_ENABLE
		/** 구글 시트가 로드 되었을 경우 */
		private void OnLoadGoogleSheets(CServicesManager a_oSender, bool a_bIsSuccess) {
			// Do Something
		}

		/** 버전 정보 구글 시트를 로드했을 경우 */
		private void OnLoadVerInfoGoogleSheet(CServicesManager a_oSender, SimpleJSON.JSONNode a_oVerInfos, Dictionary<string, STGoogleSheetInfo> a_oGoogleSheetInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				Func.LoadGoogleSheets(a_oGoogleSheetInfoDict.ExToList(), this.OnLoadGoogleSheets);
			} else {
				Func.ShowOnTableLoadFailPopup(null);
			}
		}

		/** 기타 정보 구글 시트를 로드했을 경우 */
		private void OnLoadEtcInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CEtcInfoTable.Inst.SaveEtcInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 미션 정보 구글 시트를 로드했을 경우 */
		private void OnLoadMissionInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CMissionInfoTable.Inst.SaveMissionInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 보상 정보 구글 시트를 로드했을 경우 */
		private void OnLoadRewardInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CRewardInfoTable.Inst.SaveRewardInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 리소스 정보 구글 시트를 로드했을 경우 */
		private void OnLoadResInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CResInfoTable.Inst.SaveResInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 아이템 정보 구글 시트를 로드했을 경우 */
		private void OnLoadItemInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CItemInfoTable.Inst.SaveItemInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 스킬 정보 구글 시트를 로드했을 경우 */
		private void OnLoadSkillInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CSkillInfoTable.Inst.SaveSkillInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 객체 정보 구글 시트를 로드했을 경우 */
		private void OnLoadObjInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CObjInfoTable.Inst.SaveObjInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 어빌리티 정보 구글 시트를 로드했을 경우 */
		private void OnLoadAbilityInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CAbilityInfoTable.Inst.SaveAbilityInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}

		/** 상품 정보 구글 시트를 로드했을 경우 */
		private void OnLoadProductInfoGoogleSheet(CServicesManager a_oSender, STGoogleSheetLoadInfo a_stGoogleSheetLoadInfo, Dictionary<string, SimpleJSON.JSONNode> a_oJSONNodeInfoDict, bool a_bIsSuccess) {
			// 로드 되었을 경우
			if(a_bIsSuccess) {
				CProductTradeInfoTable.Inst.SaveProductTradeInfos(a_oJSONNodeInfoDict.ExToJSONNode().ToString());
			}
		}
#endif         // #if GOOGLE_SHEET_ENABLE                                    
		#endregion         // 조건부 함수                   
	}
}
#endif          // #if EXTRA_SCRIPT_MODULE_ENABLE
