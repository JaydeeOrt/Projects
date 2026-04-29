import pyperclip,time, re

#sets the pattern
urlRegx = re.compile(r"(https?:\/\/www\.)([A-Za-z0-9.-]+)(\.[A-Za-z]{2,3})")
#Takes your clipboard
copiedText = str(pyperclip.paste())
#declared list
matches = []

#Groups output
for groups in urlRegx.findall(copiedText):
    pLEASE = ''.join([groups[0],groups[1],groups[2]])
    matches.append(pLEASE)

#checks if it is a url or not
if len(matches) > 1:
    pyperclip.copy('\n'.join(matches))
    print("Copied to clipboard: ")
    print('\n'.join(matches))
else:
    print("No web addresses found!")
#endif
print("Thank You")
time.sleep(5)