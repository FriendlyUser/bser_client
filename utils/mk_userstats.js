const userStats = {
    "code": 200,
    "message": "Success",
    "userStats": [
      {
        "seasonId": 1,
        "userNum": 189543,
        "matchingMode": 3,
        "matchingTeamMode": 1,
        "mmr": 1443,
        "nickname": "태도",
        "rank": 44070,
        "rankSize": 44071,
        "totalGames": 90,
        "totalWins": 15,
        "rankPercent": 1,
        "averageRank": 8.73,
        "averageKills": 2.63,
        "averageAssistants": 0,
        "averageHunts": 33.82,
        "top1": 0.17,
        "top2": 0.19,
        "top3": 0.27,
        "top5": 0.33,
        "top7": 0.41,
        "characterStats": [
          {
            "characterCode": 6,
            "totalGames": 90,
            "usages": 90,
            "maxKillings": 10,
            "top3": 24,
            "top3Rate": 0
          }
        ]
      },
      {
        "seasonId": 1,
        "userNum": 189543,
        "matchingMode": 3,
        "matchingTeamMode": 2,
        "mmr": 871,
        "nickname": "태도",
        "rank": 11390,
        "rankSize": 11660,
        "totalGames": 7,
        "totalWins": 3,
        "rankPercent": 0.98,
        "averageRank": 4.14,
        "averageKills": 4.14,
        "averageAssistants": 1.57,
        "averageHunts": 23.14,
        "top1": 0.43,
        "top2": 0.43,
        "top3": 0.57,
        "top5": 0.57,
        "top7": 0.71,
        "characterStats": [
          {
            "characterCode": 6,
            "totalGames": 7,
            "usages": 7,
            "maxKillings": 10,
            "top3": 4,
            "top3Rate": 1
          }
        ]
      },
      {
        "seasonId": 1,
        "userNum": 189543,
        "matchingMode": 3,
        "matchingTeamMode": 3,
        "mmr": 933,
        "nickname": "태도",
        "rank": 19374,
        "rankSize": 19897,
        "totalGames": 14,
        "totalWins": 7,
        "rankPercent": 0.97,
        "averageRank": 3.21,
        "averageKills": 3.5,
        "averageAssistants": 2.71,
        "averageHunts": 18,
        "top1": 0.5,
        "top2": 0.5,
        "top3": 0.5,
        "top5": 0.79,
        "top7": 1,
        "characterStats": [
          {
            "characterCode": 6,
            "totalGames": 14,
            "usages": 14,
            "maxKillings": 8,
            "top3": 7,
            "top3Rate": 0
          }
        ]
      }
    ]
  }

  for (const [prop, value] of Object.entries(userStats.userStats[0])) {
    let cProperty
    if (typeof value === 'string') {
      cProperty = `public string ${prop} {get; set;}`
    } else if (typeof value === 'number') {
      cProperty = `public double ${prop} {get; set;}`
    } else if (typeof value === 'object') {
      cProperty = `public IDictionary<string, int> ${prop} {get; set;}`
    } else if (Array.isArray(value)){
    } else {
      cProperty = `public string ${prop} {get; set;}`
    }
    console.log(cProperty)
  }

const charStats = {
      "characterCode": 6,
      "totalGames": 14,
      "usages": 14,
      "maxKillings": 8,
      "top3": 7,
      "top3Rate": 0
    }
console.log('---------- CHARACTER STATS --------------')
for (const [prop, value] of Object.entries(charStats)) {
    cProperty = `public string ${prop} {get; set;}`
    console.log(cProperty)
}