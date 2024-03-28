import os
import sys

oNameProj = sys.argv[1]

os.system(f"python UpdaterModule.py \"{oNameProj}\"")
os.system(f"python ExecuterCmdModule.py \"{oNameProj}\" \"git gc --force\"")
