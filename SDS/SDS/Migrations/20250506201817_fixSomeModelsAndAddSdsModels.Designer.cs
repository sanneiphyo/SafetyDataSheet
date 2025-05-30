﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDS.Data;

#nullable disable

namespace SDS.Migrations
{
    [DbContext(typeof(SdsDbContext))]
    [Migration("20250506201817_fixSomeModelsAndAddSdsModels")]
    partial class fixSomeModelsAndAddSdsModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SDS.Models.HeaderHImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Base64Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SdsModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SdsModelId");

                    b.ToTable("HeaderHImages");
                });

            modelBuilder.Entity("SDS.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SDS.Models.SDSContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadersHDId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadersHId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SDSContents");
                });

            modelBuilder.Entity("SDS.Models.SdsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcuteToxicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appearance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AspirationHazard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AutoIgnitionTemp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BioaccumulationPotential")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiologicalDefinition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoilingPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BulkTranprt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carcinogenicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CasNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalSafetyAssessment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalStability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassificationContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConditionsToAvoid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContainmentMethods")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContainsInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControlParameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EcoToxicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EinecsNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineeringMeasures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentalExposure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentalHazards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentalPrecautions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtinguishingMediaContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyeContactFirstAid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyeDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EyeProtection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FemaNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirefighterAdviceContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlashPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GermCell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandProtection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HazardClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HazardStatements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HazardousDecomposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HazardousReactions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HygieneMeasures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IbcCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentifiedUses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncompatibleMaterials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IngestionFirstAid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InhalationFirstAid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabelContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalAttention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeltingPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Odour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherAdverseEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherChemicalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherHazards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherProtection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackingGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PbtAssessment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersistenceDegradability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalPrecautions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalProtection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoToxicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precautionary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecautionaryStatements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProtectiveEquipmentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReactivityInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefractiveIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativeDensity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepeatedExposure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReproductiveToxicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RespiratoryEquipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RevisionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevisionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SafeHandlingPrecautions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SafeStorageConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SafetyRegulations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionReferences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignalWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SingleExposure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinContactFirstAid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinCorrosion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinProtection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinSensitization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoilMobility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolubilityInWater")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialHazardsContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialPrecautions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecificEndUses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubstancesContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplementary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomsEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToxicologicalEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnAir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnRoad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnSea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VapourPressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WasteTreatmentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SdsModels");
                });

            modelBuilder.Entity("SDS.Models.HeaderHImage", b =>
                {
                    b.HasOne("SDS.Models.SdsModel", null)
                        .WithMany("Images")
                        .HasForeignKey("SdsModelId");
                });

            modelBuilder.Entity("SDS.Models.SdsModel", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
