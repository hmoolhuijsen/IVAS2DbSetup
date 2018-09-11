using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


// Zie voor uitleg https://docs.microsoft.com/en-us/ef/core/get-started/uwp/getting-started


namespace IVAS2.DbSetup
{
    public class Model
    {
        public class IVAS2Context : DbContext
        {
            public DbSet<Answer> Answer { get; set; }
            public DbSet<AnswerType> AnswerType { get; set; }
            public DbSet<ApplicationSetting> ApplicationSetting { get; set; }
            public DbSet<Color> Color { get; set; }
            public DbSet<CommentType> CommentType { get; set; }
            public DbSet<Examiner> Examiner { get; set; }
            public DbSet<Image> Image { get; set; }
            public DbSet<Language> Language { get; set; }
            public DbSet<Scan> Scan { get; set; }
            public DbSet<Terminal> Terminal { get; set; }
            public DbSet<IVAS2_User> IVAS2_User { get; set; }

            public DbSet<ExceptionCase> ExceptionCase { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var sqlOption =
                optionsBuilder.UseSqlServer(@"Server=ASL00323V\SQLEXPRESS;Database=IVAS2_Db_Test;Trusted_Connection=True;Integrated Security=true;", null);

                // Create with a userID
                //optionsBuilder.UseSqlServer(@"Server=ASL00323V\SQLEXPRESS;Database=IVAS2_Db_Dev;User Instance=true;User Id=login_any_db;Password=Zaq12wsx;",
                //    sqlServerOptionsAction: sqlOptions =>
                //    {
                //        sqlOptions.EnableRetryOnFailure(maxRetryCount: 5,
                //        maxRetryDelay: TimeSpan.FromSeconds(30),
                //        errorNumbersToAdd: null);
                //    });
            }
        }

        public class Answer
        {
            public int AnswerID { get; set; }
            public int ScanID { get; set; }
            public Scan Scan { get; set; }
            public Examiner Examiner { get; set; }
            public int AnswerTypeID { get; set; }
            public AnswerType AnswerType { get; set; }
            public int ColorID { get; set; }
            public Color Color { get; set; }
            public int? ImageID { get; set; }
            public Image Image { get; set; }
            public string Text { get; set; }

        }

        public class AnswerType
        {
            public int AnswerTypeID { get; set; }
            public string AnswerTypeName { get; set; }

            public ICollection<Answer> Answers { get; set; }
        }

        public class ApplicationSetting
        {
            public int ApplicationSettingID { get; set; }
            public string ApplicationSettingName { get; set; }
            public string ApplicationSettingValue { get; set; }
            public bool IsValueNumeric { get; set; }

        }

        public class Color
        {
            public int ColorID { get; set; }
            public string ColorName { get; set; }

            public ICollection<Answer> Answers { get; set; }
        }

        public class CommentType
        {
            public int CommentTypeID { get; set; }
            public string CommentTypeName { get; set; }
            public bool? Popup { get; set; }

            public ICollection<Scan> Scans { get; set; }
        }

        public class Examiner
        {
            public int ExaminerID { get; set; }
            public string ExaminerName { get; set; }

            public ICollection<Answer> Answers { get; set; }
        }

        public class Image
        {
            public int ImageID { get; set; }
            public string OriginalPath { get; set; }
            public byte[] ImageData { get; set; }

            public Answer Answer { get; set; }

        }

        public class Language
        {
            [Key]
            public int TermID { get; set; }
            public string Dutch { get; set; }
            public string English { get; set; }
        }

        public class Scan
        {
            public int ScanID { get; set; }
            public DateTime ScanTime { get; set; }
            public int TerminalID { get; set; }
            public Terminal Terminal { get; set; }
            public int UserID { get; set; }
            public IVAS2_User IVAS2_User { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public bool ManualCheck { get; set; }
            public string DocumentType { get; set; }
            public string DocumentNumber { get; set; }
            public string IssuingCountry { get; set; }
            public string Nationality { get; set; }
            public DateTime DateOfIssue { get; set; }
            public string UserComment { get; set; }
            public int CommentTypeID { get; set; }
            public CommentType CommentType { get; set; }
            public int? CaseID { get; set; }
            public byte[] Sample { get; set; }
            public string IssuingCountryCode { get; set; }

            public ICollection<Answer> Answers { get; set; }
        }

        public class Terminal
        {
            public int TerminalID { get; set; }
            public string TerminalDescription { get; set; }

            public ICollection<Scan> Scans { get; set; }
        }

        public class IVAS2_User
        {
            [Key]
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string UserLevel { get; set; }

            public ICollection<Scan> Scans { get; set; }
        }

        public class ExceptionCase
        {
            [Key]
            public int CaseID { get; set; }
            public string Message { get; set; }
            public string InnerMessage { get; set; }
        }
    }
}
