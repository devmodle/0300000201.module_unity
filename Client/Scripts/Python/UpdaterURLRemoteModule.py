import os
import sys

oNameProj = sys.argv[1]

oInfosSubmodule = [
	{
		"Name": ".Module.Unity.Research",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/lkstudio.dante.common/0300000001.module_unityresearch.git"
	},

	{
		"Name": ".Module.Unity.Research.Define",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/lkstudio.dante.common/0300000001.module_unityresearchdefine.git"
	},

	{
		"Name": ".Module.Unity.Research.Utility",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/lkstudio.dante.common/0300000001.module_unityresearchutility.git"
	},

	{
		"Name": ".Module.Unity.Research.Importer",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/lkstudio.dante.common/0300000001.module_unityresearchimporter.git"
	},

	{
		"Name": ".Module.Unity",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommon.git"
	},

	{
		"Name": ".Module.Unity.Define",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommondefine.git"
	},

	{
		"Name": ".Module.Unity.Access",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonaccess.git"
	},

	{
		"Name": ".Module.Unity.Factory",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonfactory.git"
	},

	{
		"Name": ".Module.Unity.Extension",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonextension.git"
	},

	{
		"Name": ".Module.Unity.Function",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonfunction.git"
	},

	{
		"Name": ".Module.Unity.Utility",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonutility.git"
	},
	
	{
		"Name": ".Module.Unity.Externals",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonexternals.git"
	},

	{
		"Name": ".Module.Unity.Ads",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonads.git"
	},

	{
		"Name": ".Module.Unity.Flurry",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonflurry.git"
	},
	
	{
		"Name": ".Module.Unity.Facebook",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonfacebook.git"
	},

	{
		"Name": ".Module.Unity.Firebase",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonfirebase.git"
	},

	{
		"Name": ".Module.Unity.AppsFlyer",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonappsflyer.git"
	},
	
	{
		"Name": ".Module.Unity.GameCenter",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommongamecenter.git"
	},

	{
		"Name": ".Module.Unity.Purchase",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonpurchase.git"
	},

	{
		"Name": ".Module.Unity.Notification",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonnotification.git"
	},

	{
		"Name": ".Module.Unity.Playfab",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonplayfab.git"
	},
	
	{
		"Name": ".Module.Unity.Importer",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonimporter.git"
	},

	{
		"Name": ".Module.Unity.PluginsNative",
		"Path": f"{oNameProj}/Modules",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_nativeplugins.git"
	},

	{
		"Name": ".Module.Unity.Packages",
		"Path": f"{oNameProj}/Modules",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitypackages.git"
	}
]

# 경로를 탐색한다
def FindPath(a_oPathBase):
	for i in range(0, 10):
		# 디렉토리가 존재 할 경우
		if os.path.exists(a_oPathBase):
			return a_oPathBase

		a_oPathBase = f"../{a_oPathBase}"
		
	return a_oPathBase

for oInfoSubmodule in oInfosSubmodule:
	oPath = FindPath(f"{oInfoSubmodule['Path']}/{oInfoSubmodule['Name']}")
	oPathCur = os.getcwd()
	
	# 서브 모듈이 존재 할 경우
	if os.path.exists(oPath):
		try:
			os.chdir(oPath)
			os.system(f"git remote set-url origin \"{oInfoSubmodule['URL']}\"")
		finally:
			os.chdir(oPathCur)
