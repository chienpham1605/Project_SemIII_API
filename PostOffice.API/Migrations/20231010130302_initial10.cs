using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostOffice.API.Migrations
{
    public partial class initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    area_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyScopeCreateDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    min_value = table.Column<float>(type: "real", nullable: false),
                    max_value = table.Column<float>(type: "real", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyScopeCreateDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyServicePrice",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zone_type_id = table.Column<int>(type: "int", nullable: false),
                    money_scope_id = table.Column<int>(type: "int", nullable: false),
                    fee = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyServicePrice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyServicePriceDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zone_type_id = table.Column<int>(type: "int", nullable: false),
                    money_scope_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyServicePriceDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ParcelServicePrice",
                columns: table => new
                {
                    parcel_price_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zone_type_id = table.Column<int>(type: "int", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    parcel_type_id = table.Column<int>(type: "int", nullable: false),
                    scope_weight_id = table.Column<int>(type: "int", nullable: false),
                    service_price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelServicePrice", x => x.parcel_price_id);
                });

            migrationBuilder.CreateTable(
                name: "ZoneTypeDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zone_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneTypeDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pincodes",
                columns: table => new
                {
                    pincode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pincodes", x => x.pincode);
                    table.ForeignKey(
                        name: "FK_Pincodes_Areas_area_id",
                        column: x => x.area_id,
                        principalTable: "Areas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoneyScope",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    min_value = table.Column<float>(type: "real", nullable: false),
                    max_value = table.Column<float>(type: "real", nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyScope", x => x.id);
                    table.ForeignKey(
                        name: "FK_MoneyScope_MoneyServicePrice_id",
                        column: x => x.id,
                        principalTable: "MoneyServicePrice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelServices",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    delivery_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelServices", x => x.service_id);
                    table.ForeignKey(
                        name: "FK_ParcelServices_ParcelServicePrice_service_id",
                        column: x => x.service_id,
                        principalTable: "ParcelServicePrice",
                        principalColumn: "parcel_price_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    max_length = table.Column<float>(type: "real", nullable: false),
                    max_width = table.Column<float>(type: "real", nullable: false),
                    max_height = table.Column<float>(type: "real", nullable: false),
                    max_weight = table.Column<float>(type: "real", nullable: false),
                    over_dimension_rate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelType", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParcelType_ParcelServicePrice_id",
                        column: x => x.id,
                        principalTable: "ParcelServicePrice",
                        principalColumn: "parcel_price_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightScope",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    min_weight = table.Column<float>(type: "real", nullable: false),
                    max_weight = table.Column<float>(type: "real", nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightScope", x => x.id);
                    table.ForeignKey(
                        name: "FK_WeightScope_ParcelServicePrice_id",
                        column: x => x.id,
                        principalTable: "ParcelServicePrice",
                        principalColumn: "parcel_price_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZoneTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    zone_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneTypes", x => x.id);
                    table.ForeignKey(
                        name: "FK_ZoneTypes_MoneyServicePrice_id",
                        column: x => x.id,
                        principalTable: "MoneyServicePrice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZoneTypes_ParcelServicePrice_id",
                        column: x => x.id,
                        principalTable: "ParcelServicePrice",
                        principalColumn: "parcel_price_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoneyOrder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sender_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sender_pincode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    sender_address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    sender_phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    sender_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sender_national_identity_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    receiver_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    receiver_pincode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    receiver_address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    receiver_phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    receiver_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receiver_national_identity_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    transfer_status = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    transfer_value = table.Column<float>(type: "real", nullable: false),
                    transfer_fee = table.Column<float>(type: "real", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    parcel_type_id = table.Column<int>(type: "int", nullable: false),
                    payer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    send_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    receive_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_charge = table.Column<float>(type: "real", nullable: false),
                    MoneyServicePriceid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyOrder", x => x.id);
                    table.ForeignKey(
                        name: "FK_MoneyOrder_AppUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoneyOrder_MoneyServicePrice_MoneyServicePriceid",
                        column: x => x.MoneyServicePriceid,
                        principalTable: "MoneyServicePrice",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MoneyOrder_Pincodes_receiver_pincode",
                        column: x => x.receiver_pincode,
                        principalTable: "Pincodes",
                        principalColumn: "pincode");
                    table.ForeignKey(
                        name: "FK_MoneyOrder_Pincodes_sender_pincode",
                        column: x => x.sender_pincode,
                        principalTable: "Pincodes",
                        principalColumn: "pincode");
                });

            migrationBuilder.CreateTable(
                name: "OfficeBranchs",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    branch_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch_phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeBranchs", x => x.id);
                    table.ForeignKey(
                        name: "FK_OfficeBranchs_Pincodes_pincode",
                        column: x => x.pincode,
                        principalTable: "Pincodes",
                        principalColumn: "pincode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelOrder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sender_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sender_pincode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sender_address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sender_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    sender_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    receiver_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    receiver_pincode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    receiver_address = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    receiver_phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    receiver_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    order_status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    desciption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    note = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    parcel_length = table.Column<float>(type: "real", nullable: false),
                    parcel_height = table.Column<float>(type: "real", nullable: false),
                    parcel_width = table.Column<float>(type: "real", nullable: false),
                    parcel_weight = table.Column<float>(type: "real", nullable: false),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    parcel_type_id = table.Column<int>(type: "int", nullable: false),
                    payer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    payment_method = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    send_date = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: false),
                    receive_date = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: false),
                    vpp_value = table.Column<float>(type: "real", nullable: false),
                    total_charge = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelOrder", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParcelOrder_AppUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParcelOrder_ParcelServices_service_id",
                        column: x => x.service_id,
                        principalTable: "ParcelServices",
                        principalColumn: "service_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParcelOrder_ParcelType_parcel_type_id",
                        column: x => x.parcel_type_id,
                        principalTable: "ParcelType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ParcelOrder_Pincodes_receiver_pincode",
                        column: x => x.receiver_pincode,
                        principalTable: "Pincodes",
                        principalColumn: "pincode");
                    table.ForeignKey(
                        name: "FK_ParcelOrder_Pincodes_sender_pincode",
                        column: x => x.sender_pincode,
                        principalTable: "Pincodes",
                        principalColumn: "pincode");
                });

            migrationBuilder.CreateTable(
                name: "TrackHistories",
                columns: table => new
                {
                    track_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    new_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    update_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    new_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackHistories", x => x.track_id);
                    table.ForeignKey(
                        name: "FK_TrackHistories_AppUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackHistories_ParcelOrder_order_id",
                        column: x => x.order_id,
                        principalTable: "ParcelOrder",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "d7444940-efd6-462d-9fba-9266269e698b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Create_date", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "c06376fc-9b48-4ef0-9c87-b703aeb0c270", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "onlinepostofficegroup4@gmail.com", true, "Pham", "Chien", false, null, "onlinepostofficegroup4@gmail.com", "admin", "AQAAAAEAACcQAAAAEF7fgEdZ4MUU+uSxcepcNuRQyaFfb7U6vbC+A7/aznwTeK5mwL6ZGaJnRWOTz2Eilw==", null, false, "", false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_MoneyOrder_MoneyServicePriceid",
                table: "MoneyOrder",
                column: "MoneyServicePriceid");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyOrder_receiver_pincode",
                table: "MoneyOrder",
                column: "receiver_pincode");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyOrder_sender_pincode",
                table: "MoneyOrder",
                column: "sender_pincode");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyOrder_user_id",
                table: "MoneyOrder",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeBranchs_pincode",
                table: "OfficeBranchs",
                column: "pincode");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelOrder_parcel_type_id",
                table: "ParcelOrder",
                column: "parcel_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelOrder_receiver_pincode",
                table: "ParcelOrder",
                column: "receiver_pincode");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelOrder_sender_pincode",
                table: "ParcelOrder",
                column: "sender_pincode");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelOrder_service_id",
                table: "ParcelOrder",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelOrder_user_id",
                table: "ParcelOrder",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pincodes_area_id",
                table: "Pincodes",
                column: "area_id");

            migrationBuilder.CreateIndex(
                name: "IX_TrackHistories_EmployeeId",
                table: "TrackHistories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackHistories_order_id",
                table: "TrackHistories",
                column: "order_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "MoneyOrder");

            migrationBuilder.DropTable(
                name: "MoneyScope");

            migrationBuilder.DropTable(
                name: "MoneyScopeCreateDTO");

            migrationBuilder.DropTable(
                name: "MoneyServicePriceDTO");

            migrationBuilder.DropTable(
                name: "OfficeBranchs");

            migrationBuilder.DropTable(
                name: "TrackHistories");

            migrationBuilder.DropTable(
                name: "WeightScope");

            migrationBuilder.DropTable(
                name: "ZoneTypeDTO");

            migrationBuilder.DropTable(
                name: "ZoneTypes");

            migrationBuilder.DropTable(
                name: "ParcelOrder");

            migrationBuilder.DropTable(
                name: "MoneyServicePrice");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ParcelServices");

            migrationBuilder.DropTable(
                name: "ParcelType");

            migrationBuilder.DropTable(
                name: "Pincodes");

            migrationBuilder.DropTable(
                name: "ParcelServicePrice");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
