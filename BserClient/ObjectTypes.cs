using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
namespace BserClient.Types
{
    [ExcludeFromCodeCoverage]
    public class GameDataObj
    {
        public double ActionCost { get; set; }
        public double Area { get; set; }
        public double AreaSound { get; set; }
        public double BotAiModel { get; set; }
        public double BotCraft { get; set; }
        public double BotMastery { get; set; }
        public double BotNickName { get; set; }
        public double BotSkillBuild { get; set; }
        public double BulletCapacity { get; set; }
        public double Character { get; set; }
        public double CharacterAttributes { get; set; }
        public double CharacterExp { get; set; }
        public double CharacterLevelUpStat { get; set; }
        public double CharacterMastery { get; set; }
        public double CharacterModeModifier { get; set; }
        public double CharacterState { get; set; }
        public double CharacterStateGroup { get; set; }
        public double CharacterVoice { get; set; }
        public double CharacterVoiceRandomCount { get; set; }
        public double Collectible { get; set; }
        public double ControlTypeUse { get; set; }
        public double CriticalChance { get; set; }
        public double DropGroup { get; set; }
        public double EffectAndSound { get; set; }
        public double Emotion { get; set; }
        public double FootStep { get; set; }
        public double GameRankExp { get; set; }
        public double HookLineProjectile { get; set; }
        public double HowToFindItem { get; set; }
        public double ItemArmor { get; set; }
        public double ItemConsumable { get; set; }
        public double ItemMisc { get; set; }
        public double ItemSearchOption { get; set; }
        public double ItemSpawn { get; set; }
        public double ItemSpecial { get; set; }
        public double ItemWeapon { get; set; }
        public double KeyText { get; set; }
        public double Level { get; set; }
        public double MasteryExp { get; set; }
        public double MasteryLevel { get; set; }
        public double MatchingQueueTier { get; set; }
        public double Mission { get; set; }
        public double Monster { get; set; }
        public double MonsterLevelUpStat { get; set; }
        public double MonsterSpawnLevel { get; set; }
        public double NaviCollectAndHunt { get; set; }
        public double NearByArea { get; set; }
        public double Noise { get; set; }
        public double PreMadeTeamTierRestrict { get; set; }
        public double ProductAsset { get; set; }
        public double ProductCharacter { get; set; }
        public double ProductInstant { get; set; }
        public double ProjectileSetting { get; set; }
        public double RecommendedArea { get; set; }
        public double RecommendedItemList { get; set; }
        public double RecommendedList { get; set; }
        public double RestrictedArea { get; set; }
        public double Reward { get; set; }
        public double RewardItem { get; set; }
        public double SecurityConsolEvent { get; set; }
        public double ServerRegion { get; set; }
        public double Skill { get; set; }
        public double SkillEvolution { get; set; }
        public double SkillEvolutionPoint { get; set; }
        public double SkillExtension { get; set; }
        public double SkillGroup { get; set; }
        public double SoundGroup { get; set; }
        public double StartItem { get; set; }
        public double SummonObject { get; set; }
        public double TimeOfDay { get; set; }
        public double TutorialReward { get; set; }
        public double WeaponAnimatorLayers { get; set; }
        public double WeaponMount { get; set; }
        public double WeaponRoute { get; set; }
        public double WeaponTypeInfo { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class UserRankObj: UserObj
    {
        public double rank { get; set; }
        public double mmr { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class UserObj
    {
        public double userNum { get; set; }
        public string nickname { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class UserGameObj
    {
        public int userNum { get; set; }
        public string nickname { get; set; }
        public double gameId { get; set; }
        public double seasonId { get; set; }
        public double matchingMode { get; set; }
        public double matchingTeamMode { get; set; }
        public double characterNum { get; set; }
        public double characterLevel { get; set; }
        public double gameRank { get; set; }
        public double playerKill { get; set; }
        public double playerAssistant { get; set; }
        public double monsterKill { get; set; }
        public double bestWeapon { get; set; }
        public double bestWeaponLevel { get; set; }
        /// \todo map to object inside of key value pair
        public IDictionary<string, double> masteryLevel { get; set; }
        /// \todo map to object inside of key value pair
        public IDictionary<string, double> equipment { get; set; }
        public double versionMajor { get; set; }
        public double versionMinor { get; set; }
        public IDictionary<string, double> skillLevelInfo { get; set; }
        public IDictionary<string, double> skillOrderInfo { get; set; }
        public double maxHp { get; set; }
        public double maxSp { get; set; }
        public double attackPower { get; set; }
        public double defense { get; set; }
        public double hpRegen { get; set; }
        public double spRegen { get; set; }
        public double attackSpeed { get; set; }
        public double moveSpeed { get; set; }
        public double outOfCombatMoveSpeed { get; set; }
        public double sightRange { get; set; }
        public double attackRange { get; set; }
        public double criticalStrikeChance { get; set; }
        public double criticalStrikeDamage { get; set; }
        public double coolDownReduction { get; set; }
        public double lifeSteal { get; set; }
        public double amplifierToMonster { get; set; }
        public double trapDamage { get; set; }
        public double gainExp { get; set; }
        public string startDtm { get; set; }
        public double duration { get; set; }
        public double mmrBefore { get; set; }
        public double damageToPlayer { get; set; }
        public double damageToMonster { get; set; }
        public double killerUserNum { get; set; }
        public double playTime { get; set; }
        public double watchTime { get; set; }
        public double totalTime { get; set; }
        public double botAdded { get; set; }
        public double botRemain { get; set; }
        public double restrictedAreaAccelerated { get; set; }
        public double safeAreas { get; set; }
        public string killer { get; set; }
        public string killDetail { get; set; }
        public string causeOfDeath { get; set; }
        public double teamNumber { get; set; }
        public double preMade { get; set; }
        public double gainedNormalMmrKFactor { get; set; }

        public string serverName {get; set;}
    }

    [ExcludeFromCodeCoverage]
    public class UserStatsObj
    {
        public double seasonId { get; set; }
        public double userNum { get; set; }
        public double matchingMode { get; set; }
        public double matchingTeamMode { get; set; }
        public double mmr { get; set; }
        public string nickname { get; set; }
        public double rank { get; set; }
        public double rankSize { get; set; }
        public double totalGames { get; set; }
        public double totalWins { get; set; }
        public double rankPercent { get; set; }
        public double averageRank { get; set; }
        public double averageKills { get; set; }
        public double averageAssistants { get; set; }
        public double averageHunts { get; set; }
        public double top1 { get; set; }
        public double top2 { get; set; }
        public double top3 { get; set; }
        public double top5 { get; set; }
        public double top7 { get; set; }
        public List<UserStatsCharacterStatsObj> characterStats { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class UserStatsCharacterStatsObj
    {
        public int characterCode { get; set; }
        public int totalGames { get; set; }
        public int usages { get; set; }
        public int maxKillings { get; set; }
        public double top3 { get; set; }
        public double top3Rate { get; set; }
    }


}
