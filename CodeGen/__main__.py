import os
from .config import templates, types, header

def createPathToFileIfNotExisting(path: str):
    combined = ""
    for p in path.split("/"):
        combined += p + "/"
        try:
            os.mkdir(combined)
        except FileExistsError:
            pass
def generateClassNameFriendlyString(s: str):
    s = s.replace('.', '')
    if len(s) == 1:
        return s.upper()
    s = s[0].upper() + s[1:len(s)]
    return s

def processTemplate(templateContents, outPath, filename):
    createPathToFileIfNotExisting(outPath)
    for t in types:
        toWrite = templateContents.replace("``type``", t)
        toWrite = toWrite.replace("``typeClassname``", generateClassNameFriendlyString(t))
        with open(outPath + "/" + filename.replace("``typeClassname``", generateClassNameFriendlyString(t)), 'w') as f:
            f.write(header + "\n" + toWrite)


def runOnEveryTemplateContents(callback):
    for template in templates:
        with open(template['templatePath'], 'r') as f:
            processTemplate(f.read(), template['outPath'], template['filename'])

def main():
    runOnEveryTemplateContents(processTemplate)

if __name__ == '__main__':
    main()
