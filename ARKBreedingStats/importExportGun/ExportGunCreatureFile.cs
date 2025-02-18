﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ARKBreedingStats.importExportGun
{
    /// <summary>
    /// Structure of the export file created by the export gun mod.
    /// </summary>
    [JsonObject]
    internal class ExportGunCreatureFile
    {
        public string DinoName { get; set; }
        public string SpeciesName { get; set; }
        public string TribeName { get; set; }
        public string TamerString { get; set; }
        public string OwningPlayerName { get; set; }
        public string ImprinterName { get; set; }
        public int OwningPlayerID { get; set; }
        public int DinoID1 { get; set; }
        public int DinoID2 { get; set; }
        public Ancestry Ancestry { get; set; }
        public string BlueprintPath { get; set; }
        public Stat[] Stats { get; set; }
        public byte[] ColorSetIndices { get; set; }
        public Dictionary<byte, float[]> ColorSetValues { get; set; }
        public bool IsFemale { get; set; }
        public float NextAllowedMatingTimeDuration { get; set; }
        public float BabyAge { get; set; }
        public bool MutagenApplied { get; set; }
        public bool Neutered { get; set; }
        public int RandomMutationsMale { get; set; }
        public int RandomMutationsFemale { get; set; }
        /// <summary>
        /// Hash of the server multipliers, used to make sure the stat multipliers are from this server when importing via the export gun mod.
        /// </summary>
        public string ServerMultipliersHash { get; set; }
        public float TameEffectiveness { get; set; }
        public int BaseCharacterLevel { get; set; }
        public float DinoImprintingQuality { get; set; }
    }

    [JsonObject]
    internal class Ancestry
    {
        public string MaleName { get; set; }
        public int MaleDinoId1 { get; set; }
        public int MaleDinoId2 { get; set; }
        public string FemaleName { get; set; }
        public int FemaleDinoId1 { get; set; }
        public int FemaleDinoId2 { get; set; }
    }

    [JsonObject]
    internal class Stat
    {
        public int Wild { get; set; }
        public int Tamed { get; set; }
        public float Value { get; set; }
    }
}
