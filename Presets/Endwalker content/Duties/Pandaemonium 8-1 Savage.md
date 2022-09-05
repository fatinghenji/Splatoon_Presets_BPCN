**If you have imported presets before 05.09, reimport at least multipreset and storages**

[International] Display danger zone on Gorgons mechanic cast.
```
~Lv2~{"Name":"P8S Out/Gorgons","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"","type":1,"radius":0.2,"color":2348810495,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31052],"refActorUseCastTime":true,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeHitbox":true,"onlyTargetable":true,"Filled":true}],"Phase":1}
```

[International] Multipreset: displays snakes, birds and tiles AOEs during various mechanics.
```
~Lv2~{"Name":"P8S AOE Multipreset (fire sweeps/arena tiles/first fourfold)","Group":"P8S-1","ElementsL":[{"Name":"Arena tiles/光劍畫地板","type":3,"refY":-5.0,"offY":5.0,"radius":5.0,"color":1687393270,"thicc":5.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31015],"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Sunforge (bird 1)去中間(畫圖右)","type":3,"refX":14.0,"refY":20.0,"offX":14.0,"offY":-20.0,"radius":7.0,"color":1683540695,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[30993],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"LineAddHitboxLengthXA":true},{"Name":"Sunforge (bird 2)去中間(畫圖左)","type":3,"refX":-14.0,"refY":20.0,"offX":-14.0,"offY":-20.0,"radius":7.0,"color":1683540695,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[30993],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"LineAddHitboxLengthXA":true},{"Name":"Sunforge (snake)/去兩邊","type":3,"refY":20.0,"offY":-20.0,"radius":7.0,"color":1683540695,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[30992],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true},{"Name":"Creation at command (middle)/分身去兩邊","type":3,"refY":40.0,"radius":7.0,"color":1683540695,"refActorNPCNameID":11405,"refActorRequireCast":true,"refActorCastId":[31058],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"DistanceSourceX":101.73789,"DistanceSourceY":113.62963},{"Name":"Creation at command (sides)/分身去中間","type":3,"refY":7.0,"offY":20.0,"radius":40.0,"color":1683540695,"refActorNPCNameID":11405,"refActorRequireCast":true,"refActorCastId":[31059],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"DistanceSourceX":101.73789,"DistanceSourceY":113.62963},{"Name":"Fourfold fires - first explosion/畫火圈 ","type":1,"radius":24.0,"color":1349909939,"thicc":5.0,"refActorNPCNameID":11404,"refActorRequireCast":true,"refActorCastId":[31054,31013,31014],"refActorComparisonType":6,"Filled":true}],"Phase":1}
```

[International] Octaflare, Tetraflare and Diflare storage. Places a sign on a boss indicating which flare it currently stores.
```
~Lv2~{"Name":"P8S Octaflare reminder","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":1,"radius":0.0,"overlayBGColor":3355443200,"overlayTextColor":4278255599,"overlayFScale":1.5,"thicc":0.0,"overlayText":"< Stored: SPREAD >","refActorNPCNameID":11399,"refActorUseCastTime":true,"refActorCastTimeMax":60.0,"refActorUseOvercast":true,"refActorRequireBuff":true,"refActorBuffId":[2552],"refActorComparisonType":6,"onlyTargetable":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":60.0,"Match":"(11399>30996)"}],"Phase":1}
```
```
~Lv2~{"Name":"P8S Tetraflare reminder","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":1,"radius":0.0,"overlayBGColor":3355443200,"overlayTextColor":4294965504,"overlayFScale":1.5,"thicc":0.0,"overlayText":"> Stored: 2 STACK <","refActorNPCNameID":11399,"refActorUseCastTime":true,"refActorCastTimeMax":60.0,"refActorUseOvercast":true,"refActorRequireBuff":true,"refActorBuffId":[2552],"refActorComparisonType":6,"onlyTargetable":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":60.0,"Match":"(11399>30997)"},{"Type":2,"Duration":60.0,"Match":"(11399>30998)"}],"Phase":1}
```
```
~Lv2~{"Name":"P8S Diflare reminder","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":1,"radius":0.0,"overlayBGColor":3355443200,"overlayTextColor":4278190335,"overlayFScale":1.5,"thicc":0.0,"overlayText":">>> Stored: 4 STACK <<<","refActorNPCNameID":11399,"refActorUseCastTime":true,"refActorCastTimeMax":60.0,"refActorUseOvercast":true,"refActorRequireBuff":true,"refActorBuffId":[2552],"refActorComparisonType":6,"onlyTargetable":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":60.0,"Match":"(11399>30999)"}],"Phase":1}
```

[International] Octaflare (casted only): displays your AOE and highlights players that are too close
```
~Lv2~{"Name":"P8S Octaflare spread (cast only)","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":1,"radius":6.2,"color":3355508223,"thicc":5.0,"refActorPlaceholder":["<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorComparisonType":5},{"Name":"","type":1,"radius":6.2,"color":1342177535,"thicc":5.0,"refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorComparisonType":5,"refActorType":1,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":6.5,"Match":"(11399>31005)"}],"MaxDistance":6.2,"UseDistanceLimit":true,"DistanceLimitType":1,"Phase":1}
```

[International] Tetraflare (casted only): displays tether to your designated partner if you have a static one (**you are required to modify name to be your partner's in Static partner: tether element** or disable it if your group is plagued by melee uptime strats and you have to constantly adjust) and just a reminder above your head if you do not have one.
```
~Lv2~{"Name":"P8S Tetraflare 2 stack (cast only)","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Static partner: tether","type":1,"radius":0.0,"color":3372217088,"thicc":5.0,"refActorName":"YOUR PARTNER'S NAME HERE","onlyTargetable":true,"tether":true},{"Name":"Reminder","type":1,"radius":0.0,"overlayBGColor":4278190080,"overlayTextColor":4294959104,"overlayVOffset":2.0,"overlayFScale":2.0,"thicc":0.0,"overlayText":"> 2 STACK <","refActorType":1}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":6.5,"Match":"(11399>31006)"}],"MaxDistance":6.2,"UseDistanceLimit":true,"DistanceLimitType":1,"Phase":1}
```

[International] Nest of Flamevipers. Displays line AOE from boss targeting you.
```
~Lv2~{"Name":"P8S Nest of flamevipers Self","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"","type":3,"refY":30.0,"radius":2.5,"color":1677766143,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31007],"refActorComparisonType":6,"includeRotation":true,"onlyTargetable":true,"FaceMe":true}],"Phase":1}
```

[International] Early display of second and third Cthonic Vent AOEs
```
~Lv2~{"Name":"P8S Fourfold 2nd and 3rd explosions","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Cardinal","type":1,"offY":30.0,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":3.1241393,"RotationMin":3.159046},{"Name":"Cardinal","type":1,"offY":30.0,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":1.553343,"RotationMin":1.5882496},{"Name":"Cardinal","type":1,"offY":30.0,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":-0.017453292,"RotationMin":0.017453292},{"Name":"Cardinal","type":1,"offY":30.0,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":-1.5882496,"RotationMin":-1.553343},{"Name":"Intercardinal","type":1,"offY":42.38,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":-0.80285144,"RotationMin":-0.7679449},{"Name":"Intercardinal","type":1,"offY":42.38,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":2.3387413,"RotationMin":2.3736477},{"Name":"Intercardinal","type":1,"offY":42.38,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":0.7679449,"RotationMin":0.80285144},{"Name":"Intercardinal","type":1,"offY":42.38,"radius":24.0,"color":1349909939,"refActorNPCNameID":11404,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true,"Filled":true,"LimitRotation":true,"RotationMax":-2.3736477,"RotationMin":-2.3387413}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.0,"Match":"(11399>30960)","MatchDelay":9.3},{"Type":2,"Duration":1.0,"Match":"(11399>30960)","MatchDelay":18.3}],"Phase":1,"Freezing":true,"FreezeFor":6.6,"IntervalBetweenFreezes":5.0}
```

[International] Rearing Rampage spread. Displays your AOE and AOE of players who are too close to you.
```
~Lv2~{"Name":"P8S Rearing Rampage Spread","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":1,"radius":6.2,"color":3355508223,"thicc":5.0,"refActorPlaceholder":["<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorComparisonType":5},{"Name":"","type":1,"radius":6.2,"color":1342177535,"thicc":5.0,"refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorComparisonType":5,"refActorType":1,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":13.0,"Match":"(11399>31027)"}],"MaxDistance":6.2,"UseDistanceLimit":true,"DistanceLimitType":1,"Phase":1}
```

[International] Gorgons (both): see where gorgons will end up early
```
~Lv2~{"Name":"P8S Early see Gorgons","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"","type":1,"radius":3.0,"color":3372155125,"thicc":5.0,"refActorNPCNameID":11517,"refActorRequireCast":true,"refActorCastId":[31019],"refActorComparisonType":6,"tether":true,"Filled":true}],"Phase":1}
```

[International] Gorgons (both): your line of sight. When combined with previous preset: make sure that no purple lines are within red lines and you're good. Sorry, no "don't look" image this time.
```
~Lv2~{"Name":"P8S Player sight to avoid Gorgons","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"","type":3,"refY":50.0,"radius":0.0,"thicc":10.0,"refActorType":1,"includeRotation":true,"AdditionalRotation":0.80285144},{"Name":"","type":3,"refY":50.0,"radius":0.0,"thicc":10.0,"refActorType":1,"includeRotation":true,"AdditionalRotation":5.480334}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":7.5,"Match":"(11517>31019)"}],"Phase":1}
```

[International] Second Gorgons - line AOE of illusions
```
~Lv2~{"Name":"P8S 2nd gorgons Illusory lines","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"","type":3,"refY":40.0,"radius":5.0,"color":1677762815,"refActorNPCNameID":11405,"refActorRequireCast":true,"refActorCastId":[31026],"refActorUseCastTime":true,"refActorCastTimeMax":8.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"onlyVisible":true}],"Phase":1}
```

[International] Second Gorgons - highlight people with breath/crown debuff
```
~Lv2~{"Name":"P8S 2nd gorgon debuffs","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"Stack","type":1,"radius":5.0,"overlayBGColor":4278190080,"overlayTextColor":4278190335,"thicc":7.5,"overlayText":">>> 4 stack <<<","refActorName":"*","refActorRequireBuff":true,"refActorBuffId":[3327],"refActorUseBuffTime":true,"refActorBuffTimeMax":9.0,"onlyTargetable":true},{"Name":"Petrifaction","type":1,"radius":2.0,"color":4278255605,"overlayBGColor":4278190080,"overlayTextColor":3355508223,"thicc":10.0,"overlayText":"Petrifaction","refActorName":"*","refActorRequireBuff":true,"refActorBuffId":[3352],"refActorUseBuffTime":true,"refActorBuffTimeMax":9.0,"onlyTargetable":true}],"Phase":1}
```

[International] Quadrupedal crush/impact
```
~Lv2~{"Name":"P8S Quadrupedal Stuff","Group":"P8S-1","ZoneLockH":[1088],"ElementsL":[{"Name":"Crush/Out","type":1,"offY":20.0,"radius":30.0,"color":1677780223,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31237],"refActorComparisonType":6,"includeRotation":true,"onlyTargetable":true,"Filled":true},{"Name":"Impact/Knockback","type":1,"offY":20.0,"radius":0.0,"color":4278190335,"overlayBGColor":4278190080,"overlayTextColor":4278190335,"overlayFScale":5.0,"thicc":10.0,"overlayText":"KNOCKBACK","refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31236],"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"onlyTargetable":true,"tether":true}],"Phase":1}
```

[International] Blazing Footfalls telegraphs (**you must import all, v2.1.0.7+**)
```
~Lv2~{"Name":"P8S Blazing Footfalls-1","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":0.5}],"Freezing":true,"FreezeFor":11.3,"IntervalBetweenFreezes":20.0,"Phase":1}
```
```
~Lv2~{"Name":"P8S Blazing Footfalls-2","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":3.3}],"Freezing":true,"FreezeFor":14.0,"IntervalBetweenFreezes":20.0,"FreezeDisplayDelay":8.9,"Phase":1}
```
```
~Lv2~{"Name":"P8S Blazing Footfalls-3","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":5.5}],"Freezing":true,"FreezeFor":15.4,"IntervalBetweenFreezes":20.0,"FreezeDisplayDelay":11.9,"Phase":1}
```
```
~Lv2~{"Name":"P8S Blazing Footfalls-4","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":1677721855,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":7.5}],"Freezing":true,"FreezeFor":15.8,"IntervalBetweenFreezes":20.0,"FreezeDisplayDelay":13.3,"Phase":1}
```

[International] Blazing Footfalls early telegraphs. Faint yellow color will display mechanic that will happen after next one.
```
~Lv2~{"Name":"P8S Blazing Footfalls-2 early","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"color":1006690047,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":3.3}],"Freezing":true,"FreezeFor":8.9,"IntervalBetweenFreezes":20.0,"Phase":1}
```
```
~Lv2~{"Name":"P8S Blazing Footfalls-3 early","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"color":1006690047,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":5.5}],"Freezing":true,"FreezeFor":11.9,"IntervalBetweenFreezes":20.0,"FreezeDisplayDelay":6.8,"Phase":1}
```
```
~Lv2~{"Name":"P8S Blazing Footfalls-4 early","Group":"P8S-1","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"Knockback","type":4,"radius":20.0,"coneAngleMax":360,"color":1006690047,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31036],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"FillStep":15.0,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"AOE","type":1,"radius":30.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31037],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true},{"Name":"Dash","type":3,"refY":40.0,"radius":7.0,"color":503373567,"thicc":4.0,"refActorNPCNameID":11399,"refActorRequireCast":true,"refActorCastId":[31035],"refActorCastTimeMin":9.0,"refActorCastTimeMax":12.0,"refActorUseOvercast":true,"refActorComparisonType":6,"includeRotation":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":1.5,"Match":"(11399>31032)","MatchDelay":7.5}],"Freezing":true,"FreezeFor":13.3,"IntervalBetweenFreezes":20.0,"FreezeDisplayDelay":9.8,"Phase":1}
```