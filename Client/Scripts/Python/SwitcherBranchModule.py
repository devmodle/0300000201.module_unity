import os
import sys

oNameProj = sys.argv[1]
oNameBranch = sys.argv[2]
oNameBranchOrigin = sys.argv[3]

os.system(f"python UpdaterModule.py \"{oNameProj}\"")

# 원본 브랜치 이름이 유효 할 경우
if oNameBranchOrigin:
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git checkout -b {oNameBranch} {oNameBranchOrigin}\"")
else:
	os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git checkout {oNameBranch}\"")
