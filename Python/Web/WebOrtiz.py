import requests,os,bs4

reqPage = requests.get("https://www.sccsc.edu/admissions-aid/apply/")

#Checks that webpage is available if not gives error message
try:
    reqPage.raise_for_status()
except Exception as ex:
    print(f"There was a problem: {ex}")

#Gets all html stuff from webpage
pyt = bs4.BeautifulSoup(reqPage.text,'html.parser')

#Takes html code labeld by h1 into a list
element = pyt.select('h1')

#prints list of labeled html
for i in range(len(element)):
    print(element[i].getText())