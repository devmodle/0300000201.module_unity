using System.IO;
using UnityEngine;

public class IronSourceMediationSettings : ScriptableObject{
    public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH = Path.Combine(IronSourceConstants.IRONSOURCE_RESOURCES_PATH, IronSourceConstants.IRONSOURCE_MEDIATION_SETTING_NAME + ".asset");

    [Header("Ironsource AppKey")]
    [Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
    public string AndroidAppKey = "1707b0635";
    [Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
    public string IOSAppKey = "1707b7945";

    [Header("Automatic Initialization")]
    [Tooltip("Use this flag when you wish to initialize all ad units (recommended)")]
    public bool EnableIronsourceSDKInitAPI;

    [Header("Ironsource SKAdNetwork ID")]
    [Tooltip("Add Ironsource SKAdNetworkIdentifier to your Info.plist for iOS 14+")]
    public bool AddIronsourceSkadnetworkID = true;

    [Header("Google Play Services Settings")]
    [Tooltip("Add Google Play Services normal permission for API level 31 (Android 12)")]
    public bool DeclareAD_IDPermission = true;

    [Header("Project Features")]
    public bool EnableAdapterDebug;

    public bool EnableIntegrationHelper;
}