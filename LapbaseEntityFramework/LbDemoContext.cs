using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using LapbaseBOL.LbDemo;
using LapbaseBOL.LbDemo.SPClasses;
    
namespace LapbaseEntityFramework.LbDemo
{
   

    public partial class LbDemoContext : DbContext
    {
        private static EnvironmentConfigBuilder enf = new EnvironmentConfigBuilder();
        static string connectionString = enf.getDemoCS();

        public LbDemoContext()
            : base(connectionString)
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblActionLog> tblActionLogs { get; set; }
        public virtual DbSet<tblApplicationVersion> tblApplicationVersions { get; set; }
        public virtual DbSet<tblAppSchema> tblAppSchemas { get; set; }
        public virtual DbSet<tblAppSchemaField> tblAppSchemaFields { get; set; }
        public virtual DbSet<tblAppSchemaListItem> tblAppSchemaListItems { get; set; }
        public virtual DbSet<tblBiochemistry> tblBiochemistries { get; set; }
        public virtual DbSet<tblBiochemistryChoice> tblBiochemistryChoices { get; set; }
        public virtual DbSet<tblCharacter> tblCharacters { get; set; }
        public virtual DbSet<tblCode> tblCodes { get; set; }
        public virtual DbSet<tblComplication> tblComplications { get; set; }
        public virtual DbSet<tblComplications_Bold> tblComplications_Bold { get; set; }
        public virtual DbSet<tblComplicationsLog> tblComplicationsLogs { get; set; }
        public virtual DbSet<tblDiretaryWeightLossDuration> tblDiretaryWeightLossDurations { get; set; }
        public virtual DbSet<tblDoctor> tblDoctors { get; set; }
        public virtual DbSet<tblEMRNote> tblEMRNotes { get; set; }
        public virtual DbSet<tblErrorLogFile> tblErrorLogFiles { get; set; }
        public virtual DbSet<tblFileCategory> tblFileCategories { get; set; }
        public virtual DbSet<tblFollowUpNote> tblFollowUpNotes { get; set; }
        public virtual DbSet<tblHospital> tblHospitals { get; set; }
        public virtual DbSet<tblIdealWeight> tblIdealWeights { get; set; }
        public virtual DbSet<tblLanguage> tblLanguages { get; set; }
        public virtual DbSet<tblLogo> tblLogos { get; set; }
        public virtual DbSet<tblOpEvent> tblOpEvents { get; set; }
        public virtual DbSet<tblOpEvents_Bold> tblOpEvents_Bold { get; set; }
        public virtual DbSet<tblOpEventsLog> tblOpEventsLogs { get; set; }
        public virtual DbSet<tblOpEventsLog_Bold> tblOpEventsLog_Bold { get; set; }
        public virtual DbSet<tblOrganization> tblOrganizations { get; set; }
        public virtual DbSet<tblOrganizationBiochemistry> tblOrganizationBiochemistries { get; set; }
        public virtual DbSet<tblPatientACSForm> tblPatientACSForms { get; set; }
        public virtual DbSet<tblPatientBioChemistry> tblPatientBioChemistries { get; set; }
        public virtual DbSet<tblPatientBioChemistryLog> tblPatientBioChemistryLogs { get; set; }
        public virtual DbSet<tblPatientBSForm> tblPatientBSForms { get; set; }
        public virtual DbSet<tblPatientComment> tblPatientComments { get; set; }
        public virtual DbSet<tblPatientCommentLog> tblPatientCommentLogs { get; set; }
        public virtual DbSet<tblPatientComorbidityCheck> tblPatientComorbidityChecks { get; set; }
        public virtual DbSet<tblPatientComorbidityCheckLog> tblPatientComorbidityCheckLogs { get; set; }
        public virtual DbSet<tblPatientComorbidityNotes_Bold> tblPatientComorbidityNotes_Bold { get; set; }
        public virtual DbSet<tblPatientConsult> tblPatientConsults { get; set; }
        public virtual DbSet<tblPatientConsult_Bold> tblPatientConsult_Bold { get; set; }
        public virtual DbSet<tblPatientConsult_Bold_Notes> tblPatientConsult_Bold_Notes { get; set; }
        public virtual DbSet<tblPatientConsult_Followup> tblPatientConsult_Followup { get; set; }
        public virtual DbSet<tblPatientConsultLog> tblPatientConsultLogs { get; set; }
        public virtual DbSet<tblPatientConsultLog_Bold> tblPatientConsultLog_Bold { get; set; }
        public virtual DbSet<tblPatientDocument> tblPatientDocuments { get; set; }
        public virtual DbSet<tblPatientDocumentsContent> tblPatientDocumentsContents { get; set; }
        public virtual DbSet<tblPatientDocumentsEventLog> tblPatientDocumentsEventLogs { get; set; }
        public virtual DbSet<tblPatientEMR> tblPatientEMRs { get; set; }
        public virtual DbSet<tblPatientEMRLog> tblPatientEMRLogs { get; set; }
        public virtual DbSet<tblPatientPathology> tblPatientPathologies { get; set; }
        public virtual DbSet<tblPatientPathologyData> tblPatientPathologyDatas { get; set; }
        public virtual DbSet<tblPatient> tblPatients { get; set; }
        public virtual DbSet<tblPatients_BOLD> tblPatients_BOLD { get; set; }
        public virtual DbSet<tblPatients_BOLDLog> tblPatients_BOLDLog { get; set; }
        public virtual DbSet<tblPatientsLog> tblPatientsLogs { get; set; }
        public virtual DbSet<tblPatientWeightData> tblPatientWeightDatas { get; set; }
        public virtual DbSet<tblPatientWeightDataLog> tblPatientWeightDataLogs { get; set; }
        public virtual DbSet<tblPermissionLevel> tblPermissionLevels { get; set; }
        public virtual DbSet<tblPrevOp> tblPrevOps { get; set; }
        public virtual DbSet<tblReferringDoctor> tblReferringDoctors { get; set; }
        public virtual DbSet<tblRegion> tblRegions { get; set; }
        public virtual DbSet<tblReportTemplate> tblReportTemplates { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblSRCSystemCode> tblSRCSystemCodes { get; set; }
        public virtual DbSet<tblSystemCode> tblSystemCodes { get; set; }
        public virtual DbSet<tblSystemCodes_BOLD> tblSystemCodes_BOLD { get; set; }
        public virtual DbSet<tblSystemDetail> tblSystemDetails { get; set; }
        public virtual DbSet<tblSystemNormal> tblSystemNormals { get; set; }
        public virtual DbSet<tblTempWeightLossReport> tblTempWeightLossReports { get; set; }
        public virtual DbSet<tblUserAccessPermission> tblUserAccessPermissions { get; set; }
        public virtual DbSet<tblUserActivationCode> tblUserActivationCodes { get; set; }
        public virtual DbSet<tblUserApplicationData> tblUserApplicationDatas { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
        public virtual DbSet<tblUSER> tblUSERS { get; set; }
        public virtual DbSet<tblUsersPasswordsHistory> tblUsersPasswordsHistories { get; set; }
        public virtual DbSet<tblUserTrust> tblUserTrusts { get; set; }
        public virtual DbSet<tblUsysUserObjectLog> tblUsysUserObjectLogs { get; set; }
        public virtual DbSet<tblVersionLog> tblVersionLogs { get; set; }
        public virtual DbSet<tblImportDataLog> tblImportDataLogs { get; set; }
        public virtual DbSet<BSROrganization> BSROrganizations { get; set; }
        public virtual DbSet<tblCodes_Staging> tblCodes_Staging { get; set; }
        public virtual DbSet<tblComplications_Staging> tblComplications_Staging { get; set; }
        public virtual DbSet<tblDoctors_Staging> tblDoctors_Staging { get; set; }
        public virtual DbSet<tblDocumentEventCategory> tblDocumentEventCategories { get; set; }
        public virtual DbSet<tblERROR> tblERRORS { get; set; }
        public virtual DbSet<tblHospitals_Staging> tblHospitals_Staging { get; set; }
        public virtual DbSet<tblIdealWeights_Staging> tblIdealWeights_Staging { get; set; }
        public virtual DbSet<tblOpEvents_Staging> tblOpEvents_Staging { get; set; }
        public virtual DbSet<tblPatientConsult_Staging> tblPatientConsult_Staging { get; set; }
        public virtual DbSet<tblPatients_Staging> tblPatients_Staging { get; set; }
        public virtual DbSet<tblPatientWeightData_Staging> tblPatientWeightData_Staging { get; set; }
        public virtual DbSet<tblReferringDoctors_Staging> tblReferringDoctors_Staging { get; set; }
        public virtual DbSet<tblSystemCodes_Staging> tblSystemCodes_Staging { get; set; }
        public virtual DbSet<tblSystemNormals_Staging> tblSystemNormals_Staging { get; set; }
        public virtual DbSet<tblTemplate> tblTemplates { get; set; }
        public virtual DbSet<tblImportDataException> tblImportDataExceptions { get; set; }
        public virtual DbSet<PatientDemographic> PatientDemographics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.Page)
                .IsUnicode(false);

            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.ActionDetail)
                .IsUnicode(false);

            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.PatientID)
                .IsUnicode(false);

            modelBuilder.Entity<tblActionLog>()
                .Property(e => e.RecordID)
                .IsUnicode(false);

            modelBuilder.Entity<tblApplicationVersion>()
                .Property(e => e.VersionNo)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblApplicationVersion>()
                .Property(e => e.ApplicationURL)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchema>()
                .Property(e => e.APPSCHEMA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_English)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_ARABIC)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_Spanish)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_Australian)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_German)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_French)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaField>()
                .Property(e => e.Field_Name_Portugese)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaListItem>()
                .Property(e => e.Field_ID)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaListItem>()
                .Property(e => e.List_Text_English)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaListItem>()
                .Property(e => e.List_Text_Arabic)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaListItem>()
                .Property(e => e.List_Text_Spanish)
                .IsUnicode(false);

            modelBuilder.Entity<tblAppSchemaListItem>()
                .Property(e => e.List_Text_Portugese)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistry>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistry>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistryChoice>()
                .Property(e => e.BiochemistryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistryChoice>()
                .Property(e => e.ChoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblBiochemistryChoice>()
                .Property(e => e.ChoiceDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tblCharacter>()
                .Property(e => e.Language_Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblCode>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblCode>()
                .Property(e => e.Field2)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.ComplicationCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.Complication)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.FacilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.Facility_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.AdverseSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplication>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Bold>()
                .Property(e => e.ComplicationCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Bold>()
                .Property(e => e.FacilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Bold>()
                .Property(e => e.AdverseSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Bold>()
                .Property(e => e.BoldAdverseEventID)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.ComplicationCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.Complication)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.FacilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.Facility_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.AdverseSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplicationsLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Degrees)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.Speciality)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.PrefSurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.PrefCategory)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.PrefGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.LapBandCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctor>()
                .Property(e => e.DoctorBoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblEMRNote>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblErrorLogFile>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<tblErrorLogFile>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblErrorLogFile>()
                .Property(e => e.SchemaName)
                .IsUnicode(false);

            modelBuilder.Entity<tblErrorLogFile>()
                .Property(e => e.ProcessName)
                .IsUnicode(false);

            modelBuilder.Entity<tblErrorLogFile>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<tblFileCategory>()
                .Property(e => e.Type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblFollowUpNote>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Hospital_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Hospital_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.HospitalBoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospital>()
                .Property(e => e.Region_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.Language_Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.Language_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.CultureInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<tblLogo>()
                .Property(e => e.LogoName)
                .IsUnicode(false);

            modelBuilder.Entity<tblLogo>()
                .Property(e => e.LogoPath)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.HospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.BandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ReservoirSite)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Pathway)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Indication)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Findings)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Closure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.RouxLimbLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.RouxColic)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.RouxGastric)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.RouxEnterostomy)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.VBGStomaSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.VBGStomaWrap)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.BPDIlealLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.BPDChannelLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.TubeSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevAbdoSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevAbdoSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevAbdoSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevAbdoSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevPelvicSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevPelvicSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevPelvicSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PrevPelvicSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ComcomitantSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ComcomitantSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ComcomitantSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ComcomitantSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.GeneralNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.LapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.InRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.OutRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.SurgeryStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.SurgeryEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.FirstAssistant)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.Bougie)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PreopHematocrit)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.PreopAlbumin)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvent>()
                .Property(e => e.OtherProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.DVTCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.ASACode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.SurgicalAssistance)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.Concurrent)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.IntraEvents)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.PreDischargeEvents)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.DischargeTo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.SerialNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.BandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.HospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.LastWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.HospitalID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.TimeAfterSurgeryMeasurement)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.PreDischargeSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Bold>()
                .Property(e => e.RegistryProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.HospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.BandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ReservoirSite)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Pathway)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Indication)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Findings)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Closure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.RouxLimbLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.RouxColic)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.RouxGastric)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.RouxEnterostomy)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.VBGStomaSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.VBGStomaWrap)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.BPDIlealLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.BPDChannelLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.TubeSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.Bougie)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevAbdoSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevAbdoSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevAbdoSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevAbdoSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevPelvicSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevPelvicSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevPelvicSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PrevPelvicSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ComcomitantSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ComcomitantSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ComcomitantSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ComcomitantSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.GeneralNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.LapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.InRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.OutRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.SurgeryStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.SurgeryEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.FirstAssistant)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PreopHematocrit)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.PreopAlbumin)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog>()
                .Property(e => e.OtherProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.DVTCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.ASACode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.SurgicalAssistance)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.Concurrent)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.IntraEvents)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.PreDischargeEvents)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.DischargeTo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.SerialNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.BandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.HospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.LastWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.HospitalID)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.TimeAfterSurgeryMeasurement)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.PreDischargeSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEventsLog_Bold>()
                .Property(e => e.RegistryProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.OrgDomainName)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.VersionNo)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.CultureInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.DefaultSort)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.SubmitData)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.PracticeBoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.AdminEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.IFSOCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganization>()
                .Property(e => e.connectionString)
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganizationBiochemistry>()
                .Property(e => e.BiochemistryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistry>()
                .Property(e => e.BiochemistryValue)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistry>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistry>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistry>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistryLog>()
                .Property(e => e.BiochemistryValue)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistryLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistryLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientBioChemistryLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientComment>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientCommentLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ConsultType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.Weight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.WaistCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.HipCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.SagittalDiameter)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ReservoirVolume)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageLocation1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageName1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageLocation2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ImageName2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.VideoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.VideoName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.VideoResult)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.BPRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.LipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.HBA1C)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.FSerumInsulin)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.FBloodGlucose)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.DiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.AsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.SleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.FertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.IncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.BackLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.CVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.OtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.UserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.Notes2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.GeneralReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.CardiovascularReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RespiratoryReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.GastroReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.GenitoReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ExtremitiesReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.NeurologicalReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ChiefComplaint)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.MusculoskeletalReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.SkinReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.PsychiatricReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.EndocrineReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.HematologicReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.ENTReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.EyesReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.PFSHReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.MedicationsReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.LapbandAdjustment)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.SupportGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistrySleepApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistryGerd)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistryHyperlipidemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistryDiabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistryHypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistryReoperationNote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistrySEList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult>()
                .Property(e => e.RegistrySENote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.PatientWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.BoldVisitID)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.SupportGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_EndDiab)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_EndThy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_EndOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_EndOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PulAsthma)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PulApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PulEmb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PulOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PulOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasRef)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasUlc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasGall)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasHep)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GasOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsIsc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsBlood)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsCol)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsDVT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsVen)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsAnti)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_CvsOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyDep)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyAnx)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyPhob)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyEat)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyHead)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyStroke)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_PsyOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscBack)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscHip)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscKnee)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscFeet)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscFibr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_MuscOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GenInf)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GenRen)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_GenUri)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherPso)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherSkin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherCancer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherAnemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.AUS_OtherOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Bold>()
                .Property(e => e.MedicationList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupAppointment)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupPhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupLetterPatient)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupLetterPhysician)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupTransfer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupRefuse)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupLost)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Followup>()
                .Property(e => e.FollowupTransferName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ConsultType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.Weight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.WaistCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.HipCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.SagittalDiameter)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ReservoirVolume)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageLocation1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageName1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageLocation2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ImageName2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.VideoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.VideoName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.VideoResult)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.BPRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.LipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.HBA1C)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.FSerumInsulin)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.FBloodGlucose)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.DiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.AsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.SleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.FertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.IncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.BackLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.CVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.OtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.UserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.Notes2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.GeneralReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.CardiovascularReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RespiratoryReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.GastroReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.GenitoReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ExtremitiesReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.NeurologicalReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ChiefComplaint)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.MusculoskeletalReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.SkinReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.PsychiatricReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.EndocrineReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.HematologicReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.ENTReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.EyesReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.PFSHReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.MedicationsReview)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.LapbandAdjustment)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.SupportGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistrySleepApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistryGerd)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistryHyperlipidemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistryDiabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistryHypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistryReoperationNote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistrySEList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog>()
                .Property(e => e.RegistrySENote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.PatientWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.BoldVisitID)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.SupportGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_EndDiab)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_EndThy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_EndOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_EndOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PulAsthma)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PulApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PulEmb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PulOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PulOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasRef)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasUlc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasGall)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasHep)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GasOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsIsc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsBlood)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsCol)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsDVT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsVen)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsAnti)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_CvsOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyDep)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyAnx)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyPhob)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyEat)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyHead)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyStroke)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_PsyOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscBack)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscHip)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscKnee)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscFeet)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscFibr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_MuscOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GenInf)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GenRen)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_GenUri)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherPso)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherSkin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherCancer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherAnemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherOtherName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.AUS_OtherOtherDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsultLog_Bold>()
                .Property(e => e.MedicationList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocument>()
                .Property(e => e.EventLink)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocument>()
                .Property(e => e.DocumentFileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocument>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocument>()
                .Property(e => e.Doc_Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocumentsEventLog>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientDocumentsEventLog>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_FamilyStructure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_LiveAtHome)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_SpouseName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_Children)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinRelation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinHomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_NextOfKinMobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact1Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact1Relation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact1Address)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact1HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact1Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact2Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact2Relation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact2Address)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact2HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_AddContact2Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Diabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_HeartDisease)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Hypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Gout)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Obesity)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Snoring)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_Asthma)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_HighCholesterol)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_FamilyHistory)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_PastHealth)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedSS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionSS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedGE)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionGE)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedSP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionSP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedNA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionNA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedPS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionPS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_SuggestedOA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.SpecialInvestigation_ActionOA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_PFSH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_General)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Gastro)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Cardio)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Resp)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Musculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Extr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Genito)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Skin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Neuro)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Psych)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Endo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Hema)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_ENT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Eyes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ReviewSystem_Meds)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Medication)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_ListAllergy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_ListMedication)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_Anesthetic)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_AnestheticRisk)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_HaveDrink)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_DrinkPerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_DrinkPerWeek)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_Smoke)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_SmokePerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_HaveSmokePerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_HaveSmokeYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_HaveSmokeStop)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightBirth)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightStartSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightStartHighSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightEndHighSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightWork)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_WeightMarriage)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_LoseYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_TryMethod)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_GroupList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_GroupOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_PillList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_PillOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_AdviceList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_AdviceOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_DietList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_TreatmentList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_CosmeticList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_RBS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ABS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_RFT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ABG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_EET)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_BM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_EMS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_P)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_EKG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_CX)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_GAO)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_HNG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_HNH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_HNM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_HNN)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_CH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_CP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_AA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_LSR)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_LSB)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_LSA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_MSO)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Exam_MF)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_PA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_C)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_RP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_E)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_AP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_GM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Referrals_O)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Complaint)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.ComplaintNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Management)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionRBS)
                .IsFixedLength();

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionABS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionRFT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionABG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionEET)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionBM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionEMS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionEKG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Investigation_ActionCX)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_PreviousBariatric)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Background_PreviousNonBariatric)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Allergy_DoDrugs_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Lab_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_GainYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_MedicareNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_GroupDuration)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.WeightHistory_GroupLose)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Antihypertensives)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Insulin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_SleepApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Gerd)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Hyperlipidemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Diabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Registry_Hypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMR>()
                .Property(e => e.Details_DeceasedNote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_FamilyStructure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_LiveAtHome)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_SpouseName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_Children)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinRelation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinHomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinWorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_NextOfKinMobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact1Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact1Relation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact1Address)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact1HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact1Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact2Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact2Relation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact2Address)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact2HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_AddContact2Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Diabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_HeartDisease)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Hypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Gout)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Obesity)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Snoring)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_Asthma)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_HighCholesterol)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_FamilyHistory)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_PastHealth)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_PreviousBariatric)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Background_PreviousNonBariatric)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedSS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionSS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedGE)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionGE)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedSP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionSP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedNA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionNA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedPS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionPS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_SuggestedOA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.SpecialInvestigation_ActionOA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_PFSH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_General)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Gastro)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Cardio)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Resp)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Musculo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Extr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Genito)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Skin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Neuro)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Psych)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Endo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Hema)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_ENT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Eyes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ReviewSystem_Meds)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Medication)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_ListAllergy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_ListMedication)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_Anesthetic)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_AnestheticRisk)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_HaveDrink)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_DrinkPerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_DrinkPerWeek)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_Smoke)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_SmokePerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_HaveSmokePerDay)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_HaveSmokeYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_HaveSmokeStop)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightBirth)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightStartSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightStartHighSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightEndHighSchool)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightWork)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_WeightMarriage)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_LoseYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_TryMethod)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_GroupList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_GroupOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_PillList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_PillOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_AdviceList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_AdviceOther)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_DietList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_TreatmentList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_CosmeticList)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_RBS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionRBS)
                .IsFixedLength();

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ABS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionABS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_RFT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionRFT)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ABG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionABG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_EET)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionEET)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_BM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionBM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_EMS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionEMS)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_P)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_EKG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionEKG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_CX)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Investigation_ActionCX)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_GAO)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_HNG)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_HNH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_HNM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_HNN)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_CH)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_CP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_AA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_LSR)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_LSB)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_LSA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_MSO)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Exam_MF)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_PA)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_C)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_RP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_E)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_AP)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_GM)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Referrals_O)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Complaint)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.ComplaintNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Management)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Allergy_DoDrugs_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Lab_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_GainYears)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_MedicareNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_GroupDuration)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.WeightHistory_GroupLose)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Antihypertensives)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Insulin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_SleepApnea)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Gerd)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Hyperlipidemia)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Diabetes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Registry_Hypertension)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientEMRLog>()
                .Property(e => e.Details_DeceasedNote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathology>()
                .Property(e => e.PathologyBaseline)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathology>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathology>()
                .Property(e => e.RefDr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestID)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestValue)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestUnit)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestRange)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.TestStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientPathologyData>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Name_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Reference_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Home_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Work_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Race)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Insurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrId1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrId2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrId3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RemoteDrId)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.Marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.ReferralDuration)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.SocialHistory)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrDuration1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrDuration2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrDuration3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrStatus1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrStatus2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.RefDrStatus3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatient>()
                .Property(e => e.MedicalSummary)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.Patient_CustomId)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.ChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.SocialSecurityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.EmploymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.EmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.SecondaryInsurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.TertiaryInsurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.DietryWeightLoss)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.PreCertification_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.PBS_Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.PBS_Event)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.PNBS_Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.BoldChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.InsuranceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLD>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.Patient_CustomId)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.ChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.SocialSecurityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.EmploymentStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.EmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.SecondaryInsurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.TertiaryInsurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.DietryWeightLoss)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.PreCertification_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.PBS_Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.PBS_Event)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.PNBS_Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.BoldChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_BOLDLog>()
                .Property(e => e.InsuranceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Name_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Reference_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Home_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Work_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Race)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Insurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrId1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrId2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrId3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrDuration1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrDuration2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrDuration3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrStatus1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrStatus2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RefDrStatus3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.RemoteDrId)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.Marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.ReferralDuration)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.SocialHistory)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientsLog>()
                .Property(e => e.MedicalSummary)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.StartWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.IdealWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.CurrentWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.TargetWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.LastImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseOtherDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseBloodPressureRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseLipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseDiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseAsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseAsthmaDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.AsthmaResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.AsthmaCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseRefluxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseRefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.RefluxResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.RefluxCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseOtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseSleepDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseSleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.SleepResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.SleepCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseFertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseFertilityDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.FertilityResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.FertilityCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseArthritisDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.ArthritisResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.ArthritisCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseIncontinenceDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseIncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.IncontinenceResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.IncontinenceCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseBackDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseBackPainLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BackResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BackCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseCVDDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseCVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.CVDLevelCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.CVDLevelResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseUserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseReason7)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.BaseReason8)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.MaxWeightYr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.LapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.LapbandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.InRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.OutRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.SurgeryStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.SurgeryEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.FirstAssistant)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.PreopHematocrit)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.PreopAlbumin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.OtherProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.ASACode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData>()
                .Property(e => e.Concurrent)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.StartWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.IdealWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.CurrentWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.TargetWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.LastImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseOtherDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseBloodPressureRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseLipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseDiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseAsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseAsthmaDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.AsthmaResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.AsthmaCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseRefluxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseRefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.RefluxResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.RefluxCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseOtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseSleepDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseSleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.SleepResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.SleepCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseFertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseFertilityDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.FertilityResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.FertilityCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseArthritisDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.ArthritisResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.ArthritisCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseIncontinenceDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseIncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.IncontinenceResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.IncontinenceCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseBackDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseBackPainLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BackResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BackCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseCVDDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseCVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.CVDLevelCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.CVDLevelResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseUserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseReason7)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.BaseReason8)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.MaxWeightYr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.LapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.LapbandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.InRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.OutRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.SurgeryStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.SurgeryEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.FirstAssistant)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.PreopHematocrit)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.PreopAlbumin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.OtherProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.ASACode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightDataLog>()
                .Property(e => e.Concurrent)
                .IsUnicode(false);

            modelBuilder.Entity<tblPermissionLevel>()
                .Property(e => e.PermissionLvl)
                .IsUnicode(false);

            modelBuilder.Entity<tblPermissionLevel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.PrevOpSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.PrevOpEvent)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPrevOp>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.RefDrId)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctor>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.Region_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.Region_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblReportTemplate>()
                .Property(e => e.ReportTemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<tblRole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.BoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.Score)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCode>()
                .Property(e => e.Description2)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.SystemName)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.SystemType)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.SystemCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.WOScale)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.TargetBMI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.ReferenceBMI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.BackUpLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.MFU3)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.MFU6)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.MFU12)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.FU1Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.FU2Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.FU3Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.FU4Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.EWPerCent)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.FacilityName)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemDetail>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.CustomPatientID)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.PatientName)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.LapbandDate)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.StartEW)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.WeightMeasurment)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.StartWeight)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.IdealWeight)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.Weight)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitBMI)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.BMI)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.EWLGroup025)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.EWLGroup2550)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.EWLGroup5075)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.EWLGroup75100)
                .HasPrecision(10, 1);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.strEWLL)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.HospitalName)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.HospitalName_Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.DoctorName_Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilGroup)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilSurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilLapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilApproach)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilCategory)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilLapbandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilHospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblTempWeightLossReport>()
                .Property(e => e.InitFilRegionID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.USER_SIRNAME)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.LANGUAGE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.CultureInfo)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.PermissionLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblUSER>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsersPasswordsHistory>()
                .Property(e => e.OldPassword)
                .IsFixedLength();

            modelBuilder.Entity<tblUserTrust>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.SystemUsername)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.AccessUsername)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.ObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.ActionName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.SchemaName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsysUserObjectLog>()
                .Property(e => e.SchemaCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblVersionLog>()
                .Property(e => e.Version)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblVersionLog>()
                .Property(e => e.VersionNo)
                .IsUnicode(false);

            modelBuilder.Entity<tblVersionLog>()
                .Property(e => e.ChangeLog)
                .IsUnicode(false);

            modelBuilder.Entity<tblImportDataLog>()
                .Property(e => e.InputFileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblCodes_Staging>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblCodes_Staging>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblCodes_Staging>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblCodes_Staging>()
                .Property(e => e.Field2)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.ComplicationCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.Complication)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.FacilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.Facility_Other)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.AdverseSurgery)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.DeletedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplications_Staging>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Initial)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Degrees)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.Speciality)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.PrefSurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.PrefCategory)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDoctors_Staging>()
                .Property(e => e.LapBandCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocumentEventCategory>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<tblERROR>()
                .Property(e => e.Alias_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblERROR>()
                .Property(e => e.Error_Desc_English)
                .IsUnicode(false);

            modelBuilder.Entity<tblERROR>()
                .Property(e => e.Error_Desc_Arabic)
                .IsUnicode(false);

            modelBuilder.Entity<tblERROR>()
                .Property(e => e.Error_Desc_Spanish)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Hospital_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Hospital_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.HospitalBoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblHospitals_Staging>()
                .Property(e => e.Region_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.HospitalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.BandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ReservoirSite)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Pathway)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Indication)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Procedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Findings)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.Closure)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.RouxLimbLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.RouxColic)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.RouxGastric)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.RouxEnterostomy)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.VBGStomaSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.VBGStomaWrap)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.BPDIlealLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.BPDChannelLength)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.TubeSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevAbdoSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevAbdoSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevAbdoSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevAbdoSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevPelvicSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevPelvicSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevPelvicSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.PrevPelvicSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ComcomitantSurgery1)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ComcomitantSurgery2)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ComcomitantSurgery3)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ComcomitantSurgeryNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblOpEvents_Staging>()
                .Property(e => e.GeneralNotes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ConsultType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.Weight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.WaistCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.HipCircumference)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.SagittalDiameter)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ReservoirVolume)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageLocation1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageName1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageLocation2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ImageName2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.VideoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.VideoName)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.VideoResult)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.BPRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.LipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.HBA1C)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.FSerumInsulin)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.FBloodGlucose)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.DiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.AsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.RefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.SleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.FertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.IncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.BackLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.CVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.OtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.UserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.Notes2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientConsult_Staging>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Name_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Reference_Id)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Home_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Work_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Race)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Insurance)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.RefDrId1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.RefDrId2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.RefDrId3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.CreatedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.ModifiedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.ModifiedByComputer)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.RemoteDrId)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.CreatedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.ModifiedByWindowsUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.Marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatients_Staging>()
                .Property(e => e.ReferralDuration)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Height)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.StartWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.IdealWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.CurrentWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.OpWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.TargetWeight)
                .HasPrecision(18, 9);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BMIHeight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.LastImageLocation)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.SurgeryType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Approach)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseOtherDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseBloodPressureRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseLipidRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseDiabetesRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseAsthmaLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseAsthmaDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.AsthmaResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.AsthmaCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseRefluxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseRefluxLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.RefluxResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.RefluxCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseOtherRxDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseSleepDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseSleepLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.SleepResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.SleepCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseFertilityLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseFertilityDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.FertilityResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.FertilityCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseArthritisDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseArthritisLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.ArthritisResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.ArthritisCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseIncontinenceDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseIncontinenceLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.IncontinenceResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.IncontinenceCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseBackDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseBackPainLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BackResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BackCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseCVDDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseCVDLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.CVDLevelCurrentLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.CVDLevelResolvedLevel)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserField3)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserField4)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserField5)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserMemoField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseUserMemoField2)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseReason7)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.BaseReason8)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.MaxWeightYr)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.LapbandType)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.LapbandSize)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.InRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.OutRoomTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.SurgeryStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.SurgeryEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.FirstAssistant)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.PreopHematocrit)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.PreopAlbumin)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.OtherProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.ASACode)
                .IsUnicode(false);

            modelBuilder.Entity<tblPatientWeightData_Staging>()
                .Property(e => e.Concurrent)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.RefDrId)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<tblReferringDoctors_Staging>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.BoldCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.Score)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tblSystemCodes_Staging>()
                .Property(e => e.Description2)
                .IsUnicode(false);

            modelBuilder.Entity<tblTemplate>()
                .Property(e => e.TemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<tblTemplate>()
                .Property(e => e.TemplateText)
                .IsUnicode(false);

            modelBuilder.Entity<tblImportDataException>()
                .Property(e => e.ImportFileName)
                .IsUnicode(false);

            modelBuilder.Entity<tblImportDataException>()
                .Property(e => e.PatientName)
                .IsUnicode(false);

            modelBuilder.Entity<tblImportDataException>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tblImportDataException>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);
        }
    }
}
