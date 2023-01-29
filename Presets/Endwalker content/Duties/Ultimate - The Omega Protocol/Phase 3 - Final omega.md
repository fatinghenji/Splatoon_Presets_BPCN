# Intermission
[International] Wave Repeater
```
~Lv2~{"Name":"P3 Wave Repeater","Group":"TOP","ZoneLockH":[1122],"ElementsL":[{"Name":"1","type":1,"radius":6.0,"color":2348810495,"refActorNPCNameID":7636,"refActorRequireCast":true,"refActorCastId":[31567],"refActorUseCastTime":true,"refActorCastTimeMax":5.5,"refActorUseOvercast":true,"refActorComparisonType":6,"Filled":true},{"Name":"2","type":1,"radius":6.0,"Donut":6.0,"thicc":5.0,"refActorNPCNameID":7636,"refActorRequireCast":true,"refActorCastId":[31567],"refActorUseCastTime":true,"refActorCastTimeMin":5.5,"refActorCastTimeMax":7.5,"refActorUseOvercast":true,"refActorComparisonType":6},{"Name":"3","type":1,"radius":12.0,"Donut":6.0,"thicc":5.0,"refActorNPCNameID":7636,"refActorRequireCast":true,"refActorCastId":[31567],"refActorUseCastTime":true,"refActorCastTimeMin":7.5,"refActorCastTimeMax":9.5,"refActorUseOvercast":true,"refActorComparisonType":6},{"Name":"4","type":1,"radius":18.0,"Donut":6.0,"thicc":5.0,"refActorNPCNameID":7636,"refActorRequireCast":true,"refActorCastId":[31567],"refActorUseCastTime":true,"refActorCastTimeMin":9.5,"refActorCastTimeMax":11.5,"refActorUseOvercast":true,"refActorComparisonType":6}]}
```

[International] Hands explosions
```
~Lv2~{"Name":"P3 Hands explosion","Group":"TOP","ZoneLockH":[1122],"ElementsL":[{"Name":"1-1","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":0.0,"refActorLifetimeMax":19.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":99.990585,"DistanceSourceY":86.001236,"DistanceSourceZ":-5.456968E-12,"DistanceMax":1.0},{"Name":"1-2","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":0.0,"refActorLifetimeMax":19.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":87.87839,"DistanceSourceY":107.170784,"DistanceSourceZ":9.5366886E-07,"DistanceMax":1.0},{"Name":"1-3","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":0.0,"refActorLifetimeMax":19.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":111.70796,"DistanceSourceY":107.14264,"DistanceSourceZ":-9.536798E-07,"DistanceMax":1.0},{"Name":"2-1","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":19.5,"refActorLifetimeMax":23.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":87.52321,"DistanceSourceY":92.68388,"DistanceSourceZ":-5.456968E-12,"DistanceMax":1.0},{"Name":"2-2","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":19.5,"refActorLifetimeMax":23.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":111.83778,"DistanceSourceY":93.11893,"DistanceSourceZ":9.5366886E-07,"DistanceMax":1.0},{"Name":"2-3","type":1,"radius":11.0,"color":1677721855,"refActorName":"*","refActorObjectLife":true,"refActorLifetimeMin":19.5,"refActorLifetimeMax":23.5,"onlyUnTargetable":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":99.3663,"DistanceSourceY":113.84534,"DistanceSourceZ":-5.456968E-12,"DistanceMax":1.0}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":30.0,"Match":"(7636>31567)","FireOnce":true}]}
```

[International] [Untested] Stack/spread indicators
```
~Lv2~{"Name":"P3S Stack/spread debuffs","Group":"TOP","ZoneLockH":[1122],"ElementsL":[{"Name":"stack","type":1,"radius":5.5,"color":1358954495,"refActorName":"*","refActorRequireBuff":true,"refActorBuffId":[3426],"refActorUseBuffTime":true,"refActorBuffTimeMax":15.0,"Filled":true},{"Name":"spread","type":1,"radius":5.5,"color":1358889215,"refActorName":"*","refActorRequireBuff":true,"refActorBuffId":[3425],"refActorUseBuffTime":true,"refActorBuffTimeMax":15.0,"Filled":true}]}
```

# Battle
[International] [Untested] Oversampled Wave Cannon left
```
~Lv2~{"Name":"P3 Oversampled Wave Cannon left","Group":"Omega / 絶オメガ検証戦","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"omega","type":3,"refX":-10.0,"refY":21.76,"offX":-10.0,"offY":-25.02,"radius":10.0,"color":335544575,"thicc":0.6,"refActorNPCID":7636,"FillStep":0.1,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true},{"Name":"Player left","type":3,"offY":10.0,"radius":20.0,"color":167772415,"thicc":1.0,"refActorRequireBuff":true,"refActorBuffId":[3453],"FillStep":0.1,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Player left1","type":3,"offY":-10.0,"radius":20.0,"color":167772415,"thicc":1.0,"refActorRequireBuff":true,"refActorBuffId":[3452],"FillStep":0.1,"refActorComparisonType":1,"includeRotation":true,"AdditionalRotation":1.5707964}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"(7636>31596)"}]}
```

[International] [Untested] 
```
~Lv2~{"Name":"P3 Oversampled Wave Cannon right","Group":"Omega / 絶オメガ検証戦","ZoneLockH":[1122],"DCond":5,"ElementsL":[{"Name":"omega","type":3,"refX":10.0,"refY":21.76,"offX":10.0,"offY":-25.02,"radius":10.0,"color":335544575,"thicc":0.6,"refActorNPCID":7636,"FillStep":0.1,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true},{"Name":"Player left","type":3,"refY":-10.0,"radius":20.0,"color":167772415,"thicc":1.0,"refActorRequireBuff":true,"refActorBuffId":[3453],"FillStep":0.1,"refActorComparisonType":3,"includeRotation":true,"AdditionalRotation":1.5707964,"Filled":true},{"Name":"Player left1","type":3,"offY":10.0,"radius":20.0,"color":167772415,"thicc":1.0,"refActorRequireBuff":true,"refActorBuffId":[3452],"FillStep":0.1,"refActorComparisonType":1,"includeRotation":true,"AdditionalRotation":1.5707964}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"(7636>31595)"}]}
```