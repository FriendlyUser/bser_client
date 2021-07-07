const recommendRoutes = {
  "code": 200,
  "message": "Success",
  "result": [
      {
          "recommendWeaponRoute": {
              "id": 337820,
              "title": "Test",
              "userNum": 2523108,
              "userNickname": "PSeFKa",
              "characterCode": 23,
              "slotId": 1,
              "weaponType": 15,
              "weaponCodes": "101404, 202408, 201406, 203406, 204408, 205306",
              "paths": "",
              "count": 0,
              "version": "0.30.0",
              "teamMode": 1,
              "languageCode": "en",
              "routeVersion": 1,
              "like": 0,
              "unLike": 0,
              "likeScore": 0,
              "unLikeScore": 0,
              "accumulateLike": 0,
              "accumulateUnLike": 0,
              "accumulateLikeScore": 0,
              "accumulateUnLikeScore": 0,
              "share": false,
              "updateDtm": 1619377537000,
              "starScore": 0.0,
              "accumulateStarScore": 0.0
          },
          "recommendWeaponRouteDesc": {
              "recommendWeaponRouteId": 337820,
              "descTitle": "",
              "desc": ""
          }
      }
  ],
  "next": 255210
}

for (const [prop, value] of Object.entries(recommendRoutes.result[0].recommendWeaponRoute)) {
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

console.log("====================")
for (const [prop, value] of Object.entries(recommendRoutes.result[0].recommendWeaponRouteDesc)) {
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
