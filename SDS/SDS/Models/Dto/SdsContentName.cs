using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDS.Models.Dto
{
    public static class SdsContentName
    {
        // public int Id { get; set; }
        // public string ProductId { get; set; }
        // Section 1: Identification
        public const string ProductCode = "productCode";
        public const string ProductName = "productName";
        public const string ProductImage = "productImage";
        public const string BiologicalDefinition = "biologicalDefinition";
        public const string InciName = "inciName";
        public const string CasNumber = "casNumber";
        public const string FemaNumber = "femaNumber";
        public const string EinecsNumber = "einecsNumber";
        public const string IdentifiedUses = "identifiedUses";
        public const string SupplierDetails = "supplierDetails";
        public const string EmergencyPhone = "emergencyPhone";
        // Section 2: Hazard Identification
        public const string ClassificationContent = "classificationContent";
        public const string LabelContent = "labelContent";
        public const string LabelImage = "labelImage";
        public const string SignalWord = "signalWord";
        public const string ContainsInfo = "containsInfo";
        public const string HazardStatements = "hazardStatements";
        public const string Precautionary = "precautionary"; // new
        public const string Supplementary = "supplementary"; // new
        public const string OtherHazards = "otherHazards";
        // Section 3: Composition
        public const string SubstancesContent = "substancesContent";
        // Section 4: First Aid
        public const string InhalationFirstAid = "inhalationFirstAid";
        public const string IngestionFirstAid = "ingestionFirstAid";
        public const string SkinContactFirstAid = "skinContactFirstAid";
        public const string EyeContactFirstAid = "eyeContactFirstAid";
        public const string SymptomsEffects = "symptomsEffects";
        public const string MedicalAttention = "medicalAttention";
        // Section 5: Firefighting
        public const string ExtinguishingMediaContent = "extinguishingMediaContent";
        public const string SpecialHazardsContent = "specialHazardsContent";
        public const string FirefighterAdviceContent = "firefighterAdviceContent";
        // Section 6: Accidental Release
        public const string PersonalPrecautions = "personalPrecautions";
        public const string EnvironmentalPrecautions = "environmentalPrecautions";
        public const string ContainmentMethods = "containmentMethods";
        public const string SectionReferences = "sectionReferences";
        // Section 7: Handling and Storage
        public const string SafeHandlingPrecautions = "safeHandlingPrecautions";
        public const string SafeStorageConditions = "safeStorageConditions";
        public const string SpecificEndUses = "specificEndUses";
        // Section 8: Exposure Controls/Personal Protection
        public const string ControlParameters = "controlParameters"; // new
        public const string ProtectiveEquipmentImage = "protectiveEquipmentImage";
        public const string ProcessConditions = "processConditions";
        public const string EngineeringMeasures = "engineeringMeasures";
        public const string RespiratoryEquipment = "respiratoryEquipment";
        public const string HandProtection = "handProtection";
        public const string EyeProtection = "eyeProtection";
        public const string OtherProtection = "otherProtection";
        public const string HygieneMeasures = "hygieneMeasures";
        public const string PersonalProtection = "personalProtection";
        public const string SkinProtection = "skinProtection";
        public const string EnvironmentalExposure = "environmentalExposure";
        // Section 9: Physical and Chemical Properties
        public const string Appearance = "appearance";
        public const string Colour = "colour";
        public const string Odour = "odour";
        public const string RelativeDensity = "relativeDensity";
        public const string FlashPoint = "flashPoint";
        public const string MeltingPoint = "meltingPoint";
        public const string RefractiveIndex = "refractiveIndex";
        public const string BoilingPoint = "boilingPoint";
        public const string VapourPressure = "vapourPressure";
        public const string SolubilityInWater = "solubilityInWater";
        public const string AutoIgnitionTemp = "autoIgnitionTemp";
        public const string OtherChemicalInfo = "otherChemicalInfo";
        // Section 10: Stability and Reactivity
        public const string ReactivityInfo = "reactivityInfo";
        public const string ChemicalStability = "chemicalStability";
        public const string HazardousReactions = "hazardousReactions";
        public const string ConditionsToAvoid = "conditionsToAvoid";
        public const string IncompatibleMaterials = "incompatibleMaterials";
        public const string HazardousDecomposition = "hazardousDecomposition";
        // Section 11: Toxicological Information
        public const string ToxicologicalEffects = "toxicologicalEffects";
        public const string AcuteToxicity = "acuteToxicity"; // new
        public const string SkinCorrosion = "skinCorrosion"; // new
        public const string EyeDamage = "eyeDamage"; // new
        public const string SkinSensitization = "skinSensitization"; // new
        public const string GermCell = "germCell"; // new
        public const string Carcinogenicity = "carcinogenicity"; // new
        public const string ReproductiveToxicity = "reproductiveToxicity"; // new
        public const string SingleExposure = "singleExposure"; // new
        public const string RepeatedExposure = "repeatedExposure"; // new
        public const string AspirationHazard = "aspirationHazard"; // new
        public const string PhotoToxicity = "photoToxicity"; // new
        public const string OtherInfo = "otherInfo"; // new
        // Section 12: Ecological Information
        public const string EcoToxicity = "ecoToxicity";
        public const string PersistenceDegradability = "persistenceDegradability";
        public const string BioaccumulationPotential = "bioaccumulationPotential";
        public const string SoilMobility = "soilMobility";
        public const string PbtAssessment = "pbtAssessment";
        public const string OtherAdverseEffects = "otherAdverseEffects";
        // Section 13: Disposal Considerations
        public const string WasteTreatmentMethod = "wasteTreatmentMethod";
        // Section 14: Transport Information
        public const string UnRoad = "unRoad";
        public const string UnSea = "unSea";
        public const string UnAir = "unAir";
        public const string ShippingName = "shippingName";
        public const string HazardClass = "hazardClass";
        public const string HazardClassImage = "hazardClassImage";
        public const string PackingGroup = "packingGroup";
        public const string EnvironmentalHazards = "environmentalHazards";
        public const string EnvironmentalHazardsImage = "environmentalHazardsImage";
        public const string SpecialPrecautions = "specialPrecautions"; // new
        public const string BulkTranprt = "bulkTranprt"; // new
        public const string IbcCode = "ibcCode"; // new
        // Section 15: Regulatory Information
        public const string SafetyRegulations = "safetyRegulations";
        public const string ChemicalSafetyAssessment = "chemicalSafetyAssessment";
        // Section 16: Other Information
        public const string OtherInformation = "otherInformation"; // new
        public const string PrecautionaryStatements = "precautionaryStatements"; // new
        public const string RevisionDate = "revisionDate"; // new
        public const string RevisionReason = "revisionReason"; // new
        public const string RevNo = "revNo"; // new

        // New property to hold images for each ContentID
        // public Dictionary<string, List<HeaderHImage>> ImagesByContentID { get; set; } = new Dictionary<string, List<HeaderHImage>>();
    }
}