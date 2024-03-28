import os
import sys
import platform

oNameProj = sys.argv[1]

oInfosSubmodule = [
	{
		"Name": ".Module.Unity.Research",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Research.Define",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Research.Utility",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Research.Importer",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Define",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Access",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Factory",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Extension",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Function",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Utility",
		"Path": f"{oNameProj}/Packages"
	},
	
	{
		"Name": ".Module.Unity.Externals",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Ads",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Flurry",
		"Path": f"{oNameProj}/Packages"
	},
	
	{
		"Name": ".Module.Unity.Facebook",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Firebase",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.AppsFlyer",
		"Path": f"{oNameProj}/Packages"
	},
	
	{
		"Name": ".Module.Unity.GameCenter",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Purchase",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Notification",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Playfab",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.Importer",
		"Path": f"{oNameProj}/Packages"
	},

	{
		"Name": ".Module.Unity.PluginsNative",
		"Path": f"{oNameProj}/Modules"
	},

	{
		"Name": ".Module.Unity.Packages",
		"Path": f"{oNameProj}/Modules"
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
	oModulePath = FindPath(f".git/modules/Client/{oInfoSubmodule['Path']}/{oInfoSubmodule['Name']}")

	# 서브 모듈이 존재 할 경우
	if os.path.exists(oPath):
		os.system(f"git submodule deinit -f \"{oPath}\"")
		os.system(f"git rm -f \"{oPath}\"")

	# 윈도우즈 플랫폼 일 경우
	if "WINDOWS" in platform.system().upper():
		os.system(f"rmdir /s /q \"{oPath}\"")
		os.system(f"rmdir /s /q \"{oModulePath}\"")

	else:
		os.system(f"rm -rf \"{oPath}\"")
		os.system(f"rm -rf \"{oModulePath}\"")
