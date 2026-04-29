import os, shutil, time

ogFiles = "C:\\Users\\Jaydee\\Documents\\SummerPrograms\\PythonClass\\Configuration Files\\Configuration Files"
newFiles = "C:\\Users\\Jaydee\\Documents\\SummerPrograms\\PythonClass\\Configuration Files\\New Config Files\\"







if os.path.exists(ogFiles):
     print(f"Folder '{ogFiles}' exists.")
else:
    print(f"Folder '{ogFiles}' does NOT exist.")

time.sleep(1)
if os.path.exists(newFiles):
    print(f"Folder '{newFiles}' exists.")
else:
    print(f"Folder '{newFiles}' does NOT exist.")





time.sleep(3)
#Getting users Location code 
newFileName = input("Please enter your location code: ")


for files in os.listdir(ogFiles):
    newFileName = newFileName+ "_" +files
    shutil.copy2(ogFiles,newFiles)