# Delta
[International] [Beta] Turning arms bait spot. Displays where you need to stand to bait arm correctly.
```
~Lv2~{"Name":"P5 D1 Arms Turning Bait Spots","Group":"TOP","ZoneLockH":[1122],"ElementsL":[{"Name":"right circle","type":1,"offY":3.0,"radius":0.5,"thicc":5.0,"refActorComparisonType":7,"includeRotation":true,"AdditionalRotation":1.3962634,"refActorVFXPath":"vfx/lockon/eff/m0515_turning_right01c.avfx","refActorVFXMax":10000},{"Name":"right line","type":3,"offY":3.0,"radius":0.0,"thicc":3.0,"refActorComparisonType":7,"includeRotation":true,"AdditionalRotation":1.3962634,"refActorVFXPath":"vfx/lockon/eff/m0515_turning_right01c.avfx","refActorVFXMax":10000},{"Name":"left circle","type":1,"offY":3.0,"radius":0.5,"thicc":5.0,"refActorComparisonType":7,"includeRotation":true,"AdditionalRotation":4.886922,"refActorVFXPath":"vfx/lockon/eff/m0515_turning_left01c.avfx","refActorVFXMax":10000},{"Name":"left line","type":3,"offY":3.0,"radius":0.0,"thicc":3.0,"refActorComparisonType":7,"includeRotation":true,"AdditionalRotation":4.886922,"refActorVFXPath":"vfx/lockon/eff/m0515_turning_left01c.avfx","refActorVFXMax":10000}]}
```

[International] Phase 1 Omega's cleave
```
~Lv2~{"Name":"P5 D1 Omega right","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"OMJ","type":3,"offY":-27.0,"radius":50.0,"color":167772415,"refActorNPCID":7695,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.8325957}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":" (7695>31637)"}]}
```
```
~Lv2~{"Name":"P5 D1 Omega left","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"omj","type":3,"refY":27.0,"radius":50.0,"color":1677721855,"refActorNPCID":7695,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.3089969}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":" (7695>31636)"}]}
```

# Sigma

# Omega

[International] [Beta] Clones attaks
```
~Lv2~{"Name":"P5 D3 - M/F 1st clones attacks","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"Omega-M shield","type":1,"radius":10.0,"Donut":20.0,"thicc":4.0,"refActorDataID":15721,"refActorComparisonType":3,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4},{"Name":"Omega-M blade","type":1,"radius":10.2,"color":2013266175,"thicc":3.0,"refActorDataID":15721,"refActorComparisonType":3,"onlyUnTargetable":true,"onlyVisible":true,"Filled":true,"refActorUseTransformation":true},{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":1677721855,"refActorDataID":15722,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true},{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":1677721855,"refActorDataID":15722,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"AdditionalRotation":1.5707964,"refActorUseTransformation":true},{"Name":"Omega-F feetfighter","type":3,"refX":16.0,"refY":40.0,"offX":16.0,"offY":-40.0,"radius":12.0,"color":1677721855,"refActorDataID":15722,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4},{"Name":"Omega-F feetfighter","type":3,"refX":-16.0,"refY":40.0,"offX":-16.0,"offY":-40.0,"radius":12.0,"color":1677721855,"refActorDataID":15722,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.0,"Match":">32789)","MatchDelay":10.7}],"Freezing":true,"FreezeFor":12.2}
```
```
~Lv2~{"Name":"P5 D3 - M/F 2nd clones attacks","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"Omega-M shield","type":1,"radius":10.0,"Donut":20.0,"thicc":4.0,"refActorDataID":15721,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4},{"Name":"Omega-M blade","type":1,"radius":10.2,"color":2013266175,"thicc":3.0,"refActorDataID":15721,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"onlyUnTargetable":true,"onlyVisible":true,"Filled":true,"refActorUseTransformation":true},{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":1677721855,"refActorDataID":15722,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true},{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":1677721855,"refActorDataID":15722,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"AdditionalRotation":1.5707964,"refActorUseTransformation":true},{"Name":"Omega-F feetfighter","type":3,"refX":16.0,"refY":40.0,"offX":16.0,"offY":-40.0,"radius":12.0,"color":1677721855,"refActorDataID":15722,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4},{"Name":"Omega-F feetfighter","type":3,"refX":-16.0,"refY":40.0,"offX":-16.0,"offY":-40.0,"radius":12.0,"color":1677721855,"refActorDataID":15722,"refActorRequireCast":true,"refActorCastReverse":true,"refActorCastId":[13061,13062,13063,13103,13104,13105,31530,31531,31532,13059,13060,13106,13107,31533,13043,13055,13097,13098,31526,13056,13096,31525],"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":0.5,"Match":">32789)","MatchDelay":22.3}],"Freezing":true,"FreezeFor":4.8,"FreezeDisplayDelay":0.73}
```
```
~Lv2~{"Name":"P5 D3 Diffuse Wave Cannon","Group":"TOP","ZoneLockH":[1122],"ElementsL":[{"Name":"Diffuse sides 1","type":4,"radius":20.0,"coneAngleMin":30,"coneAngleMax":150,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31644],"refActorUseCastTime":true,"refActorCastTimeMax":8.8,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"Filled":true},{"Name":"Diffuse sides 1","type":4,"radius":20.0,"coneAngleMin":210,"coneAngleMax":330,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31644],"refActorUseCastTime":true,"refActorCastTimeMax":8.8,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"Filled":true},{"Name":"Diffuse sides 2","type":4,"radius":20.0,"coneAngleMin":30,"coneAngleMax":150,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31644],"refActorUseCastTime":true,"refActorCastTimeMin":8.8,"refActorCastTimeMax":13.0,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Diffuse sides 2","type":4,"radius":20.0,"coneAngleMin":210,"coneAngleMax":330,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31644],"refActorUseCastTime":true,"refActorCastTimeMin":8.8,"refActorCastTimeMax":13.0,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Diffuse sides 1","type":4,"radius":20.0,"coneAngleMin":30,"coneAngleMax":150,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31643],"refActorUseCastTime":true,"refActorCastTimeMax":8.8,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Diffuse sides 1","type":4,"radius":20.0,"coneAngleMin":210,"coneAngleMax":330,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31643],"refActorUseCastTime":true,"refActorCastTimeMax":8.8,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Diffuse sides 2","type":4,"radius":20.0,"coneAngleMin":30,"coneAngleMax":150,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31643],"refActorUseCastTime":true,"refActorCastTimeMin":8.8,"refActorCastTimeMax":13.0,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"Filled":true},{"Name":"Diffuse sides 2","type":4,"radius":20.0,"coneAngleMin":210,"coneAngleMax":330,"refActorDataID":14669,"refActorRequireCast":true,"refActorCastId":[31643],"refActorUseCastTime":true,"refActorCastTimeMin":8.8,"refActorCastTimeMax":13.0,"refActorUseOvercast":true,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true}]}
```

# Uncategorized
Work in progress on these presets. They were submitted by community members but I am not yet fully aware what they do.
```
~Lv2~{"Name":"P5 HelloWorld near and far","Group":"","ZoneLockH":[1122],"ElementsL":[{"Name":"HelloWord  near","type":1,"radius":8.0,"color":1677721855,"refActorRequireBuff":true,"refActorBuffId":[3442],"refActorUseBuffTime":true,"refActorBuffTimeMax":6.0,"refActorComparisonType":3,"Filled":true},{"Name":"HelloWord  far","type":1,"radius":8.0,"color":1694486272,"refActorRequireBuff":true,"refActorBuffId":[3443],"refActorUseBuffTime":true,"refActorBuffTimeMax":6.0,"refActorComparisonType":3,"Filled":true}]}
```
```
~Lv2~{"Name":"P5  R2 Omega - F  clones attacks ","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":855613952,"refActorDataID":15720,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":11},{"Name":"Omega-F staff","type":3,"refY":40.0,"offY":-40.0,"radius":5.2,"color":855613952,"refActorDataID":15720,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"AdditionalRotation":1.5707964,"refActorUseTransformation":true,"refActorTransformationID":11},{"Name":"Omega-F feetfighter","type":3,"refX":16.0,"refY":40.0,"offX":16.0,"offY":-40.0,"radius":12.0,"color":855613952,"refActorDataID":15720,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4},{"Name":"Omega-F feetfighter","type":3,"refX":-16.0,"refY":40.0,"offX":-16.0,"offY":-40.0,"radius":12.0,"color":855613952,"refActorDataID":15720,"refActorComparisonType":3,"includeRotation":true,"onlyUnTargetable":true,"onlyVisible":true,"refActorUseTransformation":true,"refActorTransformationID":4}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":5.0,"Match":">32788)","MatchDelay":52.0}],"FreezeDisplayDelay":0.73}
```
```
~Lv2~{"Name":"P5 Optical unit finder - line","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"","type":3,"refY":35.0,"offY":65.0,"radius":8.0,"color":335544575,"overlayBGColor":0,"overlayTextColor":4278190080,"overlayFScale":7.0,"thicc":5.0,"overlayText":"EYE","refActorNPCNameID":7640,"FillStep":0.1,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"","type":3,"offY":35.0,"radius":8.0,"color":335544575,"overlayBGColor":0,"overlayTextColor":4278190080,"overlayFScale":7.0,"thicc":5.0,"overlayText":"EYE","refActorNPCNameID":7640,"FillStep":0.1,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Circle with tether","type":1,"Enabled":false,"offY":27.04,"radius":5.0,"color":4294967040,"overlayBGColor":0,"overlayTextColor":4278190080,"overlayFScale":7.0,"thicc":5.0,"overlayText":"EYE","refActorNPCNameID":7640,"refActorComparisonType":6,"includeRotation":true,"tether":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":5.0,"Match":" (12257>31624)","MatchDelay":9.0}]}
```
```
~Lv2~{"Name":"P5 R2 LINE","Group":"TOP","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"1","type":3,"refY":21.1,"offY":-23.74,"radius":6.0,"color":335544575,"refActorNPCNameID":7639,"FillStep":0.1,"refActorComparisonType":6,"includeRotation":true,"DistanceSourceX":100.06535,"DistanceSourceY":99.94135,"DistanceSourceZ":-5.456968E-12,"DistanceMax":0.6999999}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":11.0,"Match":">32788)","MatchDelay":42.0}]}
```
```
~Lv2~{"Name":"P5 R1 Omega-M left","Group":"","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"BOOS","type":3,"refY":20.0,"radius":35.0,"color":335544575,"thicc":0.0,"refActorNPCID":7636,"FillStep":0.1,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.5707964},{"Name":"Player lefte","type":3,"refY":-18.74,"radius":18.17,"color":184219755,"thicc":0.0,"refActorRequireBuff":true,"refActorBuffId":[3453],"FillStep":0.1,"refActorComparisonType":1,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.5707964,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":13.0,"Match":"(7636>31638)","MatchDelay":5.0}]}
```
```
~Lv2~{"Name":"P5 R1 Omega-M  right","Group":"","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"BOOS","type":3,"offY":-20.0,"radius":40.0,"color":335544575,"thicc":0.0,"refActorNPCID":7636,"FillStep":0.1,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.5707964},{"Name":"Player right","type":3,"offY":18.0,"radius":18.0,"color":184219755,"thicc":0.0,"refActorRequireBuff":true,"refActorBuffId":[3453],"refActorComparisonType":1,"includeRotation":true,"onlyVisible":true,"AdditionalRotation":1.5707964,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Match":" (7695>31638)"}]}
```