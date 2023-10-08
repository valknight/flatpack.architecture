import os
from .config import templates, header, basic, classname_replacements

def createPathToFileIfNotExisting(path: str):
    combined = ""
    for p in path.split("/"):
        combined += p + "/"
        try:
            os.mkdir(combined)
        except FileExistsError:
            pass

def generateClassNameFriendlyString(s: str):
    for c in classname_replacements:
        if c[1].startswith("++") and c[0] in s:
            s = s.replace(c[0], '')
            s = s + c[1].replace('++', '')
            continue
        if c[1].startswith("--") and c[0] in s:
            s = s.replace(c[0], '')
            s = c[1].replace('--', '') + s
            continue
        s = s.replace(c[0], c[1])
    s = s.replace('.', '')
    # Handle generics!
    while s.find('<') != -1:
        pos = s.find('<')
        s = s[0:pos] + s[pos+1].upper() + s[pos+2:len(s)]
        s.replace('<', '', 1)
    s = s.replace('>', '')
    if len(s) == 1:
        return s.upper()
    s = s[0].upper() + s[1:len(s)]
    return s

def processTemplate(templateContents, outPath, filename, typeCategories):
    createPathToFileIfNotExisting(outPath)
    types = []
    for tParent in typeCategories:
        for t in tParent:
            types.append(t)
    for t in types:
        toWrite = templateContents.replace("``type``", t)
        toWrite = toWrite.replace("``typeClassname``", generateClassNameFriendlyString(t))
        with open(outPath + "/" + filename.replace("``typeClassname``", generateClassNameFriendlyString(t)), 'w') as f:
            f.write(header + "\n" + toWrite)


def runOnEveryTemplateContents(callback):
    for template in templates:
        with open(template['templatePath'], 'r') as f:
            processTemplate(f.read(), template['outPath'], template['filename'], template.get('type_categories', [basic, ]))

def main():
    runOnEveryTemplateContents(processTemplate)

if __name__ == '__main__':
    main()
