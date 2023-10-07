templates = [
    {
        "templatePath": "Runtime/SharedData/SettableShared.cs.codegen",
        "outPath": "Runtime/SharedData/Generated/",
        "filename": "SettableShared``typeClassname``.cs"
    }
]

types = [
    "float",
    "int",
    "string",
    "Vector2",
    "Vector3",
    "Color"
]

header = """// This file is generated by CodeGen
// Do not modify it manually! Your changes will likely be overwritten
"""