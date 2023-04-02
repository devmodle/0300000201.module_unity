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
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_FXS}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_FONTS}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_SOUNDS}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_PREFABS}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName($"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.B_DIR_P_SCRIPTABLES}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),

		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Resources/Fonts",
		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Resources/Prefabs",
		$"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Resources/SpriteAtlases"
	};

	public static List<string> G_EXTRA_ASSET_P_PRELOAD_ASSET_LIST = new List<string>() {
		$"{KCEditorDefine.B_DIR_P_ASSETS}TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset"
	};
	// 경로 }

	// 스크립트 순서
	public static Dictionary<System.Type, int> G_EXTRA_SCRIPT_ORDER_DICT = new Dictionary<System.Type, int>() {
		[typeof(Ads.CAdsAdmobSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Ads.CAdsIronSrcSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(Ads.CAdsAppLovinSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,

		[typeof(FX.CFXShaderSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER,
		[typeof(FX.CFXParticleSceneManager)] = KCDefine.U_SCRIPT_O_SCENE_MANAGER
	};

	// 클래스 타입
	public static readonly Dictionary<string, System.Type> G_EXTRA_SCENE_MANAGER_TYPE_DICT = new Dictionary<string, System.Type>() {
		[KDefine.G_SCENE_N_ADS_ADMOB] = typeof(Ads.CAdsAdmobSceneManager),
		[KDefine.G_SCENE_N_ADS_IRON_SRC] = typeof(Ads.CAdsIronSrcSceneManager),
		[KDefine.G_SCENE_N_ADS_APP_LOVIN] = typeof(Ads.CAdsAppLovinSceneManager),

		[KDefine.G_SCENE_N_FX_SHADER] = typeof(FX.CFXShaderSceneManager),
		[KDefine.G_SCENE_N_FX_PARTICLE] = typeof(FX.CFXParticleSceneManager)
	};
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && EXTRA_SCRIPT_MODULE_ENABLE
