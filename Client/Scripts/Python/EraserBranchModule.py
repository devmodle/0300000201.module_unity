import os
import sys

oNameProj = sys.argv[1]
oNameBranch = sys.argv[2]

os.system(f"python UpdaterModule.py \"{oNameProj}\"")
os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git branch -D {oNameBranch}\"")
os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git push origin --delete {oNameBranch}\"")
