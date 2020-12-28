// make classes for usergames
var userGames = {
    "code": 200,
    "message": "Success",
    "userGames": [
      {
        "userNum": 189543,
        "nickname": "태도",
        "gameId": 525169,
        "seasonId": 1,
        "matchingMode": 3,
        "matchingTeamMode": 1,
        "characterNum": 6,
        "characterLevel": 18,
        "gameRank": 1,
        "playerKill": 5,
        "playerAssistant": 0,
        "monsterKill": 90,
        "bestWeapon": 7,
        "bestWeaponLevel": 20,
        "masteryLevel": {
          "7": 20,
          "8": 1,
          "101": 6,
          "102": 9,
          "103": 8,
          "104": 16,
          "201": 8,
          "202": 16,
          "203": 12,
          "204": 20
        },
        "equipment": {
          "0": 114405,
          "1": 202402,
          "2": 201409,
          "3": 203408,
          "4": 204402,
          "5": 205401
        },
        "versionMajor": 22,
        "versionMinor": 2,
        "skillLevelInfo": {
          "1006100": 2,
          "1006200": 5,
          "1006300": 3,
          "1006400": 4,
          "1006410": 1,
          "1006500": 3,
          "3007000": 2
        },
        "skillOrderInfo": {
          "1": 1006400,
          "2": 1006300,
          "3": 1006200,
          "4": 1006200,
          "5": 1006200,
          "6": 1006500,
          "7": 1006200,
          "8": 3007000,
          "9": 1006100,
          "10": 1006200,
          "11": 1006410,
          "12": 1006500,
          "13": 1006100,
          "14": 1006400,
          "15": 3007000,
          "16": 1006400,
          "17": 1006400,
          "18": 1006500,
          "19": 1006300,
          "20": 1006300
        },
        "maxHp": 2555,
        "maxSp": 1323,
        "attackPower": 164,
        "defense": 123,
        "hpRegen": 1.18,
        "spRegen": 2.75,
        "attackSpeed": 2.4,
        "moveSpeed": 2.51,
        "outOfCombatMoveSpeed": 2.83,
        "sightRange": 5.28,
        "attackRange": 6.25,
        "criticalStrikeChance": 0,
        "criticalStrikeDamage": 0,
        "coolDownReduction": 0,
        "lifeSteal": 0.21,
        "amplifierToMonster": 80,
        "trapDamage": 24,
        "gainExp": 277,
        "startDtm": "2020-12-28T08:45:40.040+0900",
        "duration": 1043,
        "mmrBefore": 1422,
        "damageToPlayer": 19261,
        "damageToMonster": 118072,
        "killerUserNum": 0,
        "playTime": 1043,
        "watchTime": 0,
        "totalTime": 1043,
        "botAdded": 0,
        "botRemain": 0,
        "restrictedAreaAccelerated": 1,
        "safeAreas": 1,
        "killer": "",
        "killDetail": "",
        "causeOfDeath": "",
        "teamNumber": 1,
        "preMade": 1,
        "gainedNormalMmrKFactor": 10.197767
      }
    ]
  }
  
  for (const [prop, value] of Object.entries(userGames.userGames[0])) {
    let cProperty
    if (typeof value === 'string') {
      cProperty = `public string ${prop} {get; set;}`
    } else if (typeof value === 'number') {
      cProperty = `public double ${prop} {get; set;}`
    } else if (typeof value === 'object') {
      cProperty = `public IDictionary<string, int> ${prop} {get; set;}`
    } else {
      cProperty = `public string ${prop} {get; set;}`
    }
    console.log(cProperty)
  }