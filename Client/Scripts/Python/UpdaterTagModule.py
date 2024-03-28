import os
import sys

oNameProj = sys.argv[1]
oNameTag = sys.argv[2]
oNameTagReplace = sys.argv[3]

oPathCur = os.getcwd()
os.system(f"python UpdaterModule.py \"{oNameProj}\"")

oInfosCmd = [
	{
		"Cmd": f"git tag -d \"{oNameTag}\"",
		"CmdSubmodule": f"python ExecuterCmdModule.py \"{oNameProj}\" \"git tag -d {oNameTag}\""
	},

	{
		"Cmd": f"git push origin --delete \"{oNameTag}\"",
		"CmdSubmodule": f"python ExecuterCmdModule.py \"{oNameProj}\" \"git push origin --delete {oNameTag}\""
	},

	{
		"Cmd": f"git tag \"{oNameTagReplace}\"",
		"CmdSubmodule": f"python ExecuterCmdModule.py \"{oNameProj}\" \"git tag {oNameTagReplace}\""
	},

	{
		"Cmd": f"git push origin --tags",
		"CmdSubmodule": f"python ExecuterCmdModule.py \"{oNameProj}\" \"git push origin --tags\""
	},
]

for oInfoCmd in oInfosCmd:
	os.chdir(f"{oPathCur}/../..")

	try:
		os.system(oInfoCmd["Cmd"])
	finally:
		os.chdir(oPathCur)
		os.system(oInfoCmd["CmdSubmodule"])
