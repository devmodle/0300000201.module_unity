using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && EXTRA_SCRIPT_MODULE_ENABLE
using UnityEditor;

/** 추가 에디터 씬 관리자 */
[InitializeOnLoad]
public static partial class CExtraEditorSceneManager {
	#region 클래스 변수

	#endregion // 클래스 변수

	#region 클래스 함수
	/** 생성자 */
	static CExtraEditorSceneManager() {
		// 플레이 모드 일 경우
		if(EditorApplication.isPlaying) {
			return;
		}

		// 스크립트 순서를 설정한다 {
		KEditorDefine.G_EXTRA_SCRIPT_ORDER_DICT.TryAdd(typeof(FX.CFXShaderSceneManager), 
			KCDefine.B_SCRIPT_O_SCENE_MANAGER);

		KEditorDefine.G_EXTRA_SCRIPT_ORDER_DICT.TryAdd(typeof(FX.CFXParticleSceneManager), 
			KCDefine.B_SCRIPT_O_SCENE_MANAGER);
		// 스크립트 순서를 설정한다 }

		// 클래스 타입을 설정한다 {
		KEditorDefine.G_EXTRA_SCENE_MANAGER_TYPE_DICT.TryAdd(KDefine.G_SCENE_N_FX_SHADER, 
			typeof(FX.CFXShaderSceneManager));

		KEditorDefine.G_EXTRA_SCENE_MANAGER_TYPE_DICT.TryAdd(KDefine.G_SCENE_N_FX_PARTICLE, 
			typeof(FX.CFXParticleSceneManager));
		// 클래스 타입을 설정한다 }

		CExtraEditorSceneManager.SetupCallbacks();
	}

	/** 상태를 갱신한다 */
	private static void Update() {
		// 상태 갱신이 불가능 할 경우
		if(CEditorAccess.IsEnableUpdateState) {
			return;
		}
	}

	/** 상태를 갱신한다 */
	private static void LateUpdate() {
		// 상태 갱신이 불가능 할 경우
		if(CEditorAccess.IsEnableUpdateState) {
			return;
		}
	}

	/** 콜백을 설정한다 */
	private static void SetupCallbacks() {
		EditorApplication.update -= CExtraEditorSceneManager.Update;
		EditorApplication.update += CExtraEditorSceneManager.Update;

		EditorApplication.update -= CExtraEditorSceneManager.LateUpdate;
		EditorApplication.update += CExtraEditorSceneManager.LateUpdate;
	}
	#endregion // 클래스 함수
}
#endif // #if UNITY_EDITOR && EXTRA_SCRIPT_MODULE_ENABLE
