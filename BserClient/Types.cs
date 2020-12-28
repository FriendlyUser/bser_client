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
        public BserGameObj data { get; set; }
    }
    [ExcludeFromCodeCoverage]
    public class BserGameObj
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
}