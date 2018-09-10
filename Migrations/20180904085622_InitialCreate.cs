using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IVAS2.DbSetup.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerType",
                columns: table => new
                {
                    AnswerTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerType", x => x.AnswerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ColorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "CommentType",
                columns: table => new
                {
                    CommentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentTypeName = table.Column<string>(nullable: true),
                    Popup = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentType", x => x.CommentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Examiner",
                columns: table => new
                {
                    ExaminerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExaminerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examiner", x => x.ExaminerID);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionCase",
                columns: table => new
                {
                    CaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    InnerMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionCase", x => x.CaseID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OriginalPath = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    TermID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dutch = table.Column<string>(nullable: true),
                    English = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.TermID);
                });

            migrationBuilder.CreateTable(
                name: "Terminal",
                columns: table => new
                {
                    TerminalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TerminalDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminal", x => x.TerminalID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Scan",
                columns: table => new
                {
                    ScanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScanTime = table.Column<DateTime>(nullable: false),
                    TerminalID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ManualCheck = table.Column<bool>(nullable: false),
                    DocumentType = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    IssuingCountry = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    UserComment = table.Column<string>(nullable: true),
                    CommentTypeID = table.Column<int>(nullable: false),
                    CaseID = table.Column<int>(nullable: true),
                    Sample = table.Column<byte[]>(nullable: true),
                    IssuingCountryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scan", x => x.ScanID);
                    table.ForeignKey(
                        name: "FK_Scan_CommentType_CommentTypeID",
                        column: x => x.CommentTypeID,
                        principalTable: "CommentType",
                        principalColumn: "CommentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scan_Terminal_TerminalID",
                        column: x => x.TerminalID,
                        principalTable: "Terminal",
                        principalColumn: "TerminalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scan_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScanID = table.Column<int>(nullable: false),
                    ExaminerID = table.Column<int>(nullable: true),
                    AnswerTypeID = table.Column<int>(nullable: false),
                    ColorID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerID);
                    table.ForeignKey(
                        name: "FK_Answer_AnswerType_AnswerTypeID",
                        column: x => x.AnswerTypeID,
                        principalTable: "AnswerType",
                        principalColumn: "AnswerTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_Color_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Color",
                        principalColumn: "ColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_Examiner_ExaminerID",
                        column: x => x.ExaminerID,
                        principalTable: "Examiner",
                        principalColumn: "ExaminerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_Image_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Image",
                        principalColumn: "ImageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_Scan_ScanID",
                        column: x => x.ScanID,
                        principalTable: "Scan",
                        principalColumn: "ScanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AnswerTypeID",
                table: "Answer",
                column: "AnswerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ColorID",
                table: "Answer",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ExaminerID",
                table: "Answer",
                column: "ExaminerID");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ImageID",
                table: "Answer",
                column: "ImageID",
                unique: true,
                filter: "[ImageID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ScanID",
                table: "Answer",
                column: "ScanID");

            migrationBuilder.CreateIndex(
                name: "IX_Scan_CommentTypeID",
                table: "Scan",
                column: "CommentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Scan_TerminalID",
                table: "Scan",
                column: "TerminalID");

            migrationBuilder.CreateIndex(
                name: "IX_Scan_UserID",
                table: "Scan",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "ExceptionCase");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "AnswerType");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Examiner");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Scan");

            migrationBuilder.DropTable(
                name: "CommentType");

            migrationBuilder.DropTable(
                name: "Terminal");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
