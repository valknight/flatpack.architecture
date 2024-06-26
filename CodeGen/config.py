# Type Categories

basic = [
    "float",
    "int",
    "string",
    "Vector2",
    "Vector3",
    "Color",
    "bool",
    "UnityEngine.PhysicMaterial",
    "UnityEngine.Mesh",
    "UnityEngine.Material"
]

lists = [

]

arrays = [
]

sharedData = [
    
]

# Template definitions

templates = [
    {
        "templatePath": "Runtime/SharedData/SettableShared.cs.codegen",
        "outPath": "Runtime/SharedData/Generated/",
        "filename": "SettableShared``typeClassname``.cs",
        "type_categories": [basic, lists, arrays]
    },
    {
        "templatePath": "Runtime/Events/Channels/BasicEventChannel.cs.codegen",
        "outPath": "Runtime/Events/Channels/Generated/",
        "filename": "BasicEventChannel``typeClassname``.cs",
        "type_categories": [basic, lists, arrays, sharedData]
    },
    {
        "templatePath": "Runtime/Events/EventInvokingSharedData/EventInvokingSharedData.cs.codegen",
        "outPath": "Runtime/Events/EventInvokingSharedData/Generated/",
        "filename": "EventInvokingShared``typeClassname``.cs",
        # We don't give this one the sharedData type, as, this could end up with circular references to itself
        # this is pretty useless
        "type_categories": [basic, lists, arrays]
    },
    {
        "templatePath": "Runtime/HelperBehaviours/EventBindings/UnityEventBinding.cs.codegen",
        "outPath": "Runtime/HelperBehaviours/EventBindings/Generated/",
        "filename": "UnityEventBinding``typeClassname``.cs",
        "type_categories": [basic, lists, arrays, sharedData]
    }
]

# String replacement definitions for classnames
# Use "++" to indicate the replacement should be treated as a suffix instead!
# Use "--" to indicate the replacement should be treated as a prefix instead!
classname_replacements = [
    ("Flatpack.Architecture.SharedData.Generics.AbstractGenericSharedData",
     "Shared"),
     ("System.Collections.Generic.List",
     "++List"),
     ("[]",
     "Array")
]
# Extra parameters

header = """// This file is generated by CodeGen
// Do not modify it manually! Your changes will likely be overwritten
"""

# Dynamic category generation!

for t in basic:
    sharedData.append(f"Flatpack.Architecture.SharedData.Generics.AbstractGenericSharedData<{t}>")
    lists.append(f"System.Collections.Generic.List<{t}>")
    arrays.append(f"{t}[]")
    
# Also add the lists and arrays to sharedData
for t in arrays:
    sharedData.append(f"Flatpack.Architecture.SharedData.Generics.AbstractGenericSharedData<{t}>")
 
for t in lists:
    sharedData.append(f"Flatpack.Architecture.SharedData.Generics.AbstractGenericSharedData<{t}>")