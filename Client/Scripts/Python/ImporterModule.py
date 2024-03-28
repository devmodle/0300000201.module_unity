import os
import sys

oNameProj = sys.argv[1]
oNameBranch = sys.argv[2]
oPathRootProj = sys.argv[3]

oInfosSubmodule = [
	{
		"Name": ".Module.Unity.Research.Importer",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/lkstudio.dante.common/0300000001.module_unityresearchimporter.git"
	},

	{
		"Name": ".Module.Unity.Importer",
		"Path": f"{oNameProj}/Packages",
		"URL": "https://gitlab.com/9tapmodule.repository/0300000001.module_unitycommonimporter.git"
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
	oURL = oInfoSubmodule["URL"]
	oPath = f"../../{oInfoSubmodule['Path']}"
	oFullPath = f"../../{oInfoSubmodule['Path']}/{oInfoSubmodule['Name']}"

	# 서브 모듈이 없을 경우
	if not os.path.exists(oFullPath):
		# 디렉토리가 없을 경우
		if not os.path.exists(oPath):
			os.makedirs(oPath)

		os.system(f"git submodule add -f \"{oURL}\" \"{oFullPath}\"")

	oSubmodulePath = f"{oPathRootProj}/{oInfoSubmodule['Path']}/{oInfoSubmodule['Name']}" if oPathRootProj else f"{oInfoSubmodule['Path']}/{oInfoSubmodule['Name']}"
	os.system(f"git submodule set-branch --branch \"{oNameBranch}\" \"{oSubmodulePath}\"")

os.system(f"python ImporterModuleResearch.py \"{oNameProj}\" \"{oNameBranch}\" \"{oPathRootProj}\"")
os.system(f"python ImporterModulePlugin.py \"{oNameProj}\" \"{oNameBranch}\" \"{oPathRootProj}\"")
os.system(f"python UpdaterURLRemoteModule.py \"{oNameProj}\"")
