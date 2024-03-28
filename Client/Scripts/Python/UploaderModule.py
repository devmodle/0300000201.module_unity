import os
import sys
import platform

oNameProj = sys.argv[1]
oMsgCommit = sys.argv[2]
oNameBranch = sys.argv[3]

os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git add .\"")
oMsgCommit = f"\"{oMsgCommit}\"" if "WINDOWS" in platform.system().upper() else oMsgCommit

# 윈도우즈 플랫폼 일 경우
if "WINDOWS" in platform.system().upper():
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git commit -m \"{oMsgCommit}\"\"")
else:
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git commit -m \'{oMsgCommit}\'\"")

# 브랜치 이름이 유효 할 경우
if oNameBranch:
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git push origin -u {oNameBranch}\"")
else:
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git push\"")
	
