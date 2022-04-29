using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 게임 센터 씬 관리자 */
	public partial class CEGameCenterSceneManager : StudyScene.CStudySceneManager {
		#region 변수
		private long m_nRecord = 0;
		private double m_dblPercent = 0.0;
		#endregion			// 변수

		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_GAME_CENTER;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if GAME_CENTER_MODULE_ENABLE
				this.ScrollViewContents.ExFindComponent<Button>("LoginBtn").onClick.AddListener(() => {
					Func.GameCenterLogin((a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"Login: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("LogoutBtn").onClick.AddListener(() => {
					Func.GameCenterLogout((a_oSender) => Func.ShowAlertPopup("Logout", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("UpdateRecordBtn").onClick.AddListener(() => {
					m_nRecord += 10;
					Func.UpdateRecord(KDefine.GC_LEADERBOARD_ID_SAMPLE, m_nRecord, (a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"UpdateRecord: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("UpdateAchievementBtn").onClick.AddListener(() => {
					m_dblPercent += 10.0;
					Func.UpdateAchievement(KDefine.GC_ACHIEVEMENT_ID_SAMPLE, m_dblPercent / KCDefine.B_UNIT_NORM_VAL_TO_PERCENT, (a_oSender, a_bIsSuccess) => Func.ShowAlertPopup($"UpdateAchievement: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("ShowLeaderboardBtn").onClick.AddListener(() => {
					CGameCenterManager.Inst.ShowLeaderboardUIs();
				});

				this.ScrollViewContents.ExFindComponent<Button>("ShowAchievementBtn").onClick.AddListener(() => {
					CGameCenterManager.Inst.ShowAchievementUIs();
				});
#endif			// #if GAME_CENTER_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
