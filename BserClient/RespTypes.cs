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
}