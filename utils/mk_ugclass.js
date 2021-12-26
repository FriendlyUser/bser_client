// make classes for usergames
var userGames = {
  "code": 200,
  "message": "Success",
  "userGames": [
    {
      "userNum": 1284642,
      "nickname": "grandfleet",
      "gameId": 14320880,
      "seasonId": 7,
      "matchingMode": 3,
      "matchingTeamMode": 1,
      "characterNum": 7,
      "skinCode": 1007001,
      "characterLevel": 14,
      "gameRank": 8,
      "playerKill": 2,
      "playerAssistant": 0,
      "monsterKill": 16,
      "bestWeapon": 2,
      "bestWeaponLevel": 12,
      "masteryLevel": {
          "1": 1,
          "2": 12,
          "204": 10,
          "102": 14,
          "103": 13,
          "104": 13,
          "201": 9,
          "202": 12,
          "101": 1
      },
      "equipment": {
          "0": 111403,
          "1": 202415,
          "2": 201410,
          "3": 203403,
          "4": 204412,
          "5": 205404
      },
      "versionMajor": 48,
      "versionMinor": 0,
      "language": "English",
      "skillLevelInfo": {
          "1007400": 5,
          "1007200": 5,
          "1007300": 1,
          "1007500": 2,
          "3002000": 1,
          "1007100": 1
      },
      "skillOrderInfo": {
          "1": 1007400,
          "2": 1007200,
          "3": 1007200,
          "4": 1007300,
          "5": 1007200,
          "6": 1007500,
          "7": 1007200,
          "8": 1007400,
          "9": 1007200,
          "10": 1007400,
          "11": 3002000,
          "12": 1007500,
          "13": 1007400,
          "14": 1007400,
          "15": 1007100
      },
      "serverName": "Seoul",
      "maxHp": 2098,
      "maxSp": 1242,
      "attackPower": 149,
      "defense": 156,
      "hpRegen": 4.95,
      "spRegen": 2.32,
      "attackSpeed": 0.8,
      "moveSpeed": 3.91,
      "outOfCombatMoveSpeed": 3.91,
      "sightRange": 9.95,
      "attackRange": 1.65,
      "criticalStrikeChance": 0.0,
      "criticalStrikeDamage": 0.0,
      "coolDownReduction": 19.0,
      "lifeSteal": 0.0,
      "normalLifeSteal": 0.0,
      "skillLifeSteal": 0.0,
      "amplifierToMonster": 20.0,
      "trapDamage": 3.0,
      "bonusCoin": 0,
      "gainExp": 128,
      "baseExp": 128,
      "bonusExp": 0,
      "startDtm": "2021-12-26T03:32:02.002+0900",
      "duration": 746,
      "mmrBefore": 1599,
      "mmrGain": 14,
      "mmrAfter": 1613,
      "playTime": 746,
      "watchTime": 0,
      "totalTime": 746,
      "botAdded": 0,
      "botRemain": 0,
      "restrictedAreaAccelerated": 0,
      "safeAreas": 9,
      "teamNumber": 6,
      "preMade": 1,
      "eventMissionResult": {},
      "gainedNormalMmrKFactor": 10.096446,
      "victory": 0,
      "craftUncommon": 22,
      "craftRare": 13,
      "craftEpic": 6,
      "craftLegend": 0,
      "damageToPlayer": 5977,
      "damageToPlayer_trap": 0,
      "damageToPlayer_basic": 848,
      "damageToPlayer_skill": 5037,
      "damageToPlayer_itemSkill": 0,
      "damageToPlayer_direct": 92,
      "damageFromPlayer": 5127,
      "damageFromPlayer_trap": 0,
      "damageFromPlayer_basic": 1803,
      "damageFromPlayer_skill": 2980,
      "damageFromPlayer_itemSkill": 30,
      "damageFromPlayer_direct": 314,
      "damageToMonster": 14483,
      "damageToMonster_trap": 0,
      "damageToMonster_basic": 4108,
      "damageToMonster_skill": 10375,
      "damageToMonster_itemSkill": 0,
      "damageToMonster_direct": 0,
      "damageFromMonster": 1720,
      "killMonsters": {
          "1": 6,
          "4": 3,
          "2": 5,
          "3": 2
      },
      "healAmount": 6161,
      "teamRecover": 0,
      "protectAbsorb": 0,
      "addSurveillanceCamera": 3,
      "addTelephotoCamera": 1,
      "removeSurveillanceCamera": 3,
      "removeTelephotoCamera": 0,
      "useHyperLoop": 3,
      "useSecurityConsole": 3,
      "giveUp": 0,
      "teamSpectator": 0,
      "routeIdOfStart": 0,
      "routeSlotId": 5,
      "placeOfStart": "15",
      "mmrAvg": 1587,
      "teamKill": 2,
      "accountLevel": 134,
      "killerUserNum": 1275484,
      "killer": "player",
      "killDetail": "우병주",
      "causeOfDeath": "강력한 펀치",
      "placeOfDeath": "6",
      "killerCharacter": "Nicky",
      "killerWeapon": "Glove",
      "killerUserNum2": 0,
      "killerUserNum3": 0,
      "fishingCount": 0,
      "useEmoticonCount": 4,
      "expireDtm": "2022-03-26T03:47:29.029+0900",
      "traitFirstCore": 7200201,
      "traitFirstSub": [
          7210101,
          7210201
      ],
      "traitSecondSub": [
          7110101,
          7110301
      ],
      "airSupplyOpenCount": [
          0,
          0,
          0,
          0,
          0,
          0,
          0
      ],
      "foodCraftCount": [
          0,
          0,
          2,
          0,
          0,
          0,
          0
      ],
      "beverageCraftCount": [
          0,
          4,
          1,
          0,
          0,
          0,
          0
      ]
   }
  ]
}

for (const [prop, value] of Object.entries(userGames.userGames[0])) {
  let cProperty
  if (typeof value === 'string') {
    cProperty = `public string ${prop} {get; set;}`
  } else if (typeof value === 'number') {
    cProperty = `public double ${prop} {get; set;}`
  } else if (Array.isArray(value)) {
    cProperty = `public List<int> ${prop} {get; set;}`
  } else if (typeof value === 'object') {
    cProperty = `public IDictionary<string, int> ${prop} {get; set;}`
  } else {
    cProperty = `public string ${prop} {get; set;}`
  }
  console.log(cProperty)
}