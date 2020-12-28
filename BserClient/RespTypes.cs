using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    public class BserData : BserRespData
    {
        public GameDataObj data { get; set; }
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
}