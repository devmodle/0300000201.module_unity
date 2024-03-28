import os
import sys

oNameProj = sys.argv[1]
oPathDirDSYM = sys.argv[2]

oPathFilePlist = f"../../{oNameProj}/Assets/Firebase/GoogleService-Info.plist"
os.system(f"../../{oNameProj}/Builds/iOS/Pods/FirebaseCrashlytics/upload-symbols -gsp \"{oPathFilePlist}\" -p ios \"{oPathDirDSYM}\"")
