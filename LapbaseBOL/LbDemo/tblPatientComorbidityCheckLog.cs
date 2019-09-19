namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientComorbidityCheckLog")]
    public partial class tblPatientComorbidityCheckLog
    {
        [Key]
        public int PatientComorbidityCheckLogID { get; set; }

        public int OrganizationCode { get; set; }

        public int PatientID { get; set; }

        public bool AUS_EndDiab { get; set; }

        public bool AUS_EndThy { get; set; }

        public bool AUS_EndOther { get; set; }

        public bool AUS_PulAsthma { get; set; }

        public bool AUS_PulApnea { get; set; }

        public bool AUS_PulEmb { get; set; }

        public bool AUS_PulOther { get; set; }

        public bool AUS_GasRef { get; set; }

        public bool AUS_GasUlc { get; set; }

        public bool AUS_GasGall { get; set; }

        public bool AUS_GasHep { get; set; }

        public bool AUS_GasOther { get; set; }

        public bool AUS_CvsIsc { get; set; }

        public bool AUS_CvsBlood { get; set; }

        public bool AUS_CvsCol { get; set; }

        public bool AUS_CvsDVT { get; set; }

        public bool AUS_CvsVen { get; set; }

        public bool AUS_CvsAnti { get; set; }

        public bool AUS_CvsOther { get; set; }

        public bool AUS_PsyDep { get; set; }

        public bool AUS_PsyAnx { get; set; }

        public bool AUS_PsyPhob { get; set; }

        public bool AUS_PsyEat { get; set; }

        public bool AUS_PsyHead { get; set; }

        public bool AUS_PsyStroke { get; set; }

        public bool AUS_PsyOther { get; set; }

        public bool AUS_MuscBack { get; set; }

        public bool AUS_MuscHip { get; set; }

        public bool AUS_MuscKnee { get; set; }

        public bool AUS_MuscFeet { get; set; }

        public bool AUS_MuscFibr { get; set; }

        public bool AUS_MuscOther { get; set; }

        public bool AUS_GenInf { get; set; }

        public bool AUS_GenRen { get; set; }

        public bool AUS_GenUri { get; set; }

        public bool AUS_OtherPso { get; set; }

        public bool AUS_OtherSkin { get; set; }

        public bool AUS_OtherCancer { get; set; }

        public bool AUS_OtherAnemia { get; set; }

        public bool AUS_OtherOther { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }
    }
}
