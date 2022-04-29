using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if EXTRA_SCRIPT_MODULE_ENABLE
namespace Etc {
	/** 결제 씬 관리자 */
	public class CEPurchaseSceneManager : StudyScene.CStudySceneManager {
		#region 프로퍼티
		public override string SceneName => KDefine.G_SCENE_N_E_PURCHASE;
		#endregion			// 프로퍼티

		#region 함수
		/** 초기화 */
		public override void Awake() {
			base.Awake();

			// 앱이 초기화 되었을 경우
			if(CSceneManager.IsAppInit) {
#if PURCHASE_MODULE_ENABLE
				this.ScrollViewContents.ExFindComponent<Button>("PurchaseConsumableBtn").onClick.AddListener(() => {
					Func.PurchaseProduct(EProductSaleKinds.SINGLE_CONSUMABLE_SAMPLE, (a_oSender, a_oProductID, a_bIsSuccess) => Func.ShowAlertPopup($"PurchaseConsumable: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("PurchaseNonConsumableBtn").onClick.AddListener(() => {
					Func.PurchaseProduct(EProductSaleKinds.SINGLE_NON_CONSUMABLE_SAMPLE, (a_oSender, a_oProductID, a_bIsSuccess) => Func.ShowAlertPopup($"PurchaseNonConsumable: {a_bIsSuccess}", null, false));
				});

				this.ScrollViewContents.ExFindComponent<Button>("RestoreBtn").onClick.AddListener(() => {
					Func.RestoreProducts((a_oSender, a_oProductList, a_bIsSuccess) => Func.ShowAlertPopup($"Restore: {a_bIsSuccess}", null, false));
				});
#endif			// #if PURCHASE_MODULE_ENABLE
			}
		}
		#endregion			// 함수
	}
}
#endif			// #if EXTRA_SCRIPT_MODULE_ENABLE
