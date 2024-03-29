using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
using BserClient.Extensions;
namespace BserClient.Types
{
    // standard response data from Bser request
    [ExcludeFromCodeCoverage]
    public class BserRespData
    {
        public int code { get; set; }
        public string message { get; set; }
    }



    [ExcludeFromCodeCoverage]
    public class BserMetaData : BserRespData
    {
        public GameDataObj data { get; set; }
    }

    /// <summary>
    /// Arbitrary data returned from the bser api given a data type.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class BserTypeData : BserRespData
    {
        // public List<Dictionary<string, System.Text.Json.JsonElement>> data {get; set; }
        public dynamic data {get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BserRankTop : BserRespData
    {
        public List<UserRankObj> topRanks { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BserRankUser : BserRespData
    {
        public UserRankObj userRank { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BserUserGames : BserRespData
    {
        public List<UserGameObj> userGames { get; set; }    
        // query string to get next games pass in for pagination
        public int next { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class BserUserStats : BserRespData
    {
        public List<UserStatsCharacterStatsObj> userStats {get; set;}
    }

    [ExcludeFromCodeCoverage]
    public class BserUserNickname : BserRespData
    {
        public UserObj user {get; set;}
    }

    [ExcludeFromCodeCoverage]
    public class BserRecommendedRoutes : BserRespData
    {
        public List<RecommendWeaponResult> result {get; set;}
    }

    
    public class BserRecommendedRoute : BserRespData
    {
        public RecommendWeaponResult result {get; set;}
    }

    public class Bserl10n : BserRespData
    {
        public l10nData data {get; set;}
    }
}