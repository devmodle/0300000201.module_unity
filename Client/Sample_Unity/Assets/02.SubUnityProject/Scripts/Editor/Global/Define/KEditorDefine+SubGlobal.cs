using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && EXTRA_SCRIPT_MODULE_ENABLE
using System.IO;
using UnityEditor;

/** 에디터 서브 전역 상수 */
public static partial class KEditorDefine {
	#region 런타임 상수
	// 경로 {
	public static List<string> G_EXTRA_DIR_P_PRELOAD_ASSET_LIST = new List<string>() {
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_FXS}").Replace(KCDefine.B_TOKEN_REV_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_FONTS}").Replace(KCDefine.B_TOKEN_REV_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_SOUNDS}").Replace(KCDefine.B_TOKEN_REV_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_PREFABS}").Replace(KCDefine.B_TOKEN_REV_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_SCRIPTABLES}").Replace(KCDefine.B_TOKEN_REV_SLASH, KCDefine.B_TOKEN_SLASH),

		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Resources/Fonts",
		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Resources/Prefabs",
		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Resources/SpriteAtlases"
	};

	public static List<string> G_EXTRA_ASSET_P_PRELOAD_ASSET_LIST = new List<string>() {
		$"{KCEditorDefine.B_DIR_P_ASSETS}TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset"
	};
	// 경로 }

	// 스크립트 순서
	public static Dictionary<System.Type, int> G_EXTRA_SCRIPT_ORDER_DICT = new Dictionary<System.Type, int>() {
		[typeof(Etc.CEEtcSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Ads.CAAdmobSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Ads.CAIronSrcSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Google.CGGoogleSheetSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,

		[typeof(Firebase.CFAuthSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Firebase.CFAnalyticsSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Firebase.CFDBSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Firebase.CFMsgSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Firebase.CFConfigSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Firebase.CFStorageSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER
	};

	// 클래스 타입
	public static readonly Dictionary<string, System.Type> G_EXTRA_SCENE_MANAGER_TYPE_DICT = new Dictionary<string, System.Type>() {
		[KDefine.G_SCENE_N_E_ETC] = typeof(Etc.CEEtcSceneManager),
		[KDefine.G_SCENE_N_A_ADMOB] = typeof(Ads.CAAdmobSceneManager),
		[KDefine.G_SCENE_N_A_IRON_SRC] = typeof(Ads.CAIronSrcSceneManager),
		[KDefine.G_SCENE_N_G_GOOGLE_SHEET] = typeof(Google.CGGoogleSheetSceneManager),

		[KDefine.G_SCENE_N_F_AUTH] = typeof(Firebase.CFAuthSceneManager),
		[KDefine.G_SCENE_N_F_ANALYTICS] = typeof(Firebase.CFAnalyticsSceneManager),
		[KDefine.G_SCENE_N_F_DB] = typeof(Firebase.CFDBSceneManager),
		[KDefine.G_SCENE_N_F_MSG] = typeof(Firebase.CFMsgSceneManager),
		[KDefine.G_SCENE_N_F_CONFIG] = typeof(Firebase.CFConfigSceneManager),
		[KDefine.G_SCENE_N_F_STORAGE] = typeof(Firebase.CFStorageSceneManager)
	};
	#endregion            // 런타임 상수                   
}
#endif         // #if UNITY_EDITOR && EXTRA_SCRIPT_MODULE_ENABLE                                                           
