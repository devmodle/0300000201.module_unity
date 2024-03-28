import os
import sys

oNameProj = sys.argv[1]

os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git fetch -p --tags --force\"")
os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git pull\"")
