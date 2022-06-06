using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class configNameConvationAndSetdefaultMaxString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_Employees_EmployeeId",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropForeignKey(
                name: "FK_SpendingDetails_Employees_EmployeeId",
                table: "SpendingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spend",
                table: "Spend");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpendingDetails",
                table: "SpendingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard");

            migrationBuilder.RenameTable(
                name: "Spend",
                newName: "spend");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "employees");

            migrationBuilder.RenameTable(
                name: "SpendingDetails",
                newName: "spending_details");

            migrationBuilder.RenameTable(
                name: "CreditCard",
                newName: "credit_card");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "spend",
                newName: "version");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "spend",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "spend",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "OutcomeSpendingDetailsId",
                table: "spend",
                newName: "outcome_spending_details_id");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "spend",
                newName: "last_update_date");

            migrationBuilder.RenameColumn(
                name: "LastUpdateBy",
                table: "spend",
                newName: "last_update_by");

            migrationBuilder.RenameColumn(
                name: "IncomeSpendingDetailsId",
                table: "spend",
                newName: "income_spending_details_id");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "spend",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "spend",
                newName: "create_by");

            migrationBuilder.RenameIndex(
                name: "IX_Spend_OutcomeSpendingDetailsId",
                table: "spend",
                newName: "ix_spend_outcome_spending_details_id");

            migrationBuilder.RenameIndex(
                name: "IX_Spend_IncomeSpendingDetailsId",
                table: "spend",
                newName: "ix_spend_income_spending_details_id");

            migrationBuilder.RenameColumn(
                name: "Hired",
                table: "employees",
                newName: "hired");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "employees",
                newName: "last_update_date");

            migrationBuilder.RenameColumn(
                name: "LastUpdateBy",
                table: "employees",
                newName: "last_update_by");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "employees",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "employees",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "employees",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "employees",
                newName: "create_by");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_Id",
                table: "employees",
                newName: "ix_employees_id");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "spending_details",
                newName: "version");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "spending_details",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "spending_details",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SpentOn",
                table: "spending_details",
                newName: "spent_on");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "spending_details",
                newName: "last_update_date");

            migrationBuilder.RenameColumn(
                name: "LastUpdateBy",
                table: "spending_details",
                newName: "last_update_by");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "spending_details",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "spending_details",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "spending_details",
                newName: "create_by");

            migrationBuilder.RenameIndex(
                name: "IX_SpendingDetails_EmployeeId",
                table: "spending_details",
                newName: "ix_spending_details_employee_id");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "credit_card",
                newName: "version");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "credit_card",
                newName: "balance");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "credit_card",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TotalOutcomeAmount",
                table: "credit_card",
                newName: "total_outcome_amount");

            migrationBuilder.RenameColumn(
                name: "TotalIncomeAmount",
                table: "credit_card",
                newName: "total_income_amount");

            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "credit_card",
                newName: "last_update_date");

            migrationBuilder.RenameColumn(
                name: "LastUpdateBy",
                table: "credit_card",
                newName: "last_update_by");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "credit_card",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "CreditCardNumber",
                table: "credit_card",
                newName: "credit_card_number");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "credit_card",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "credit_card",
                newName: "create_by");

            migrationBuilder.RenameIndex(
                name: "IX_CreditCard_EmployeeId",
                table: "credit_card",
                newName: "ix_credit_card_employee_id");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "spend",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "last_update_by",
                table: "spend",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "create_by",
                table: "spend",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_update_by",
                table: "employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "create_by",
                table: "employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "spent_on",
                table: "spending_details",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_update_by",
                table: "spending_details",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "create_by",
                table: "spending_details",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_update_by",
                table: "credit_card",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "credit_card_number",
                table: "credit_card",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "create_by",
                table: "credit_card",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_spend",
                table: "spend",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_employees",
                table: "employees",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_spending_details",
                table: "spending_details",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_credit_card",
                table: "credit_card",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_credit_card_employees_employee_id",
                table: "credit_card",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_spend_spending_details_outcome_spending_details_id",
                table: "spend",
                column: "outcome_spending_details_id",
                principalTable: "spending_details",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_spend_spending_details_spending_details_id",
                table: "spend",
                column: "income_spending_details_id",
                principalTable: "spending_details",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_spending_details_employees_employee_id",
                table: "spending_details",
                column: "employee_id",
                principalTable: "employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_credit_card_employees_employee_id",
                table: "credit_card");

            migrationBuilder.DropForeignKey(
                name: "fk_spend_spending_details_outcome_spending_details_id",
                table: "spend");

            migrationBuilder.DropForeignKey(
                name: "fk_spend_spending_details_spending_details_id",
                table: "spend");

            migrationBuilder.DropForeignKey(
                name: "fk_spending_details_employees_employee_id",
                table: "spending_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_spend",
                table: "spend");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employees",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "pk_spending_details",
                table: "spending_details");

            migrationBuilder.DropPrimaryKey(
                name: "pk_credit_card",
                table: "credit_card");

            migrationBuilder.RenameTable(
                name: "spend",
                newName: "Spend");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "spending_details",
                newName: "SpendingDetails");

            migrationBuilder.RenameTable(
                name: "credit_card",
                newName: "CreditCard");

            migrationBuilder.RenameColumn(
                name: "version",
                table: "Spend",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Spend",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Spend",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "outcome_spending_details_id",
                table: "Spend",
                newName: "OutcomeSpendingDetailsId");

            migrationBuilder.RenameColumn(
                name: "last_update_date",
                table: "Spend",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "last_update_by",
                table: "Spend",
                newName: "LastUpdateBy");

            migrationBuilder.RenameColumn(
                name: "income_spending_details_id",
                table: "Spend",
                newName: "IncomeSpendingDetailsId");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "Spend",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "Spend",
                newName: "CreateBy");

            migrationBuilder.RenameIndex(
                name: "ix_spend_outcome_spending_details_id",
                table: "Spend",
                newName: "IX_Spend_OutcomeSpendingDetailsId");

            migrationBuilder.RenameIndex(
                name: "ix_spend_income_spending_details_id",
                table: "Spend",
                newName: "IX_Spend_IncomeSpendingDetailsId");

            migrationBuilder.RenameColumn(
                name: "hired",
                table: "Employees",
                newName: "Hired");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_update_date",
                table: "Employees",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "last_update_by",
                table: "Employees",
                newName: "LastUpdateBy");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "Employees",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "Employees",
                newName: "CreateBy");

            migrationBuilder.RenameIndex(
                name: "ix_employees_id",
                table: "Employees",
                newName: "IX_Employees_Id");

            migrationBuilder.RenameColumn(
                name: "version",
                table: "SpendingDetails",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "SpendingDetails",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SpendingDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "spent_on",
                table: "SpendingDetails",
                newName: "SpentOn");

            migrationBuilder.RenameColumn(
                name: "last_update_date",
                table: "SpendingDetails",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "last_update_by",
                table: "SpendingDetails",
                newName: "LastUpdateBy");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "SpendingDetails",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "SpendingDetails",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "SpendingDetails",
                newName: "CreateBy");

            migrationBuilder.RenameIndex(
                name: "ix_spending_details_employee_id",
                table: "SpendingDetails",
                newName: "IX_SpendingDetails_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "version",
                table: "CreditCard",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "balance",
                table: "CreditCard",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CreditCard",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "total_outcome_amount",
                table: "CreditCard",
                newName: "TotalOutcomeAmount");

            migrationBuilder.RenameColumn(
                name: "total_income_amount",
                table: "CreditCard",
                newName: "TotalIncomeAmount");

            migrationBuilder.RenameColumn(
                name: "last_update_date",
                table: "CreditCard",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "last_update_by",
                table: "CreditCard",
                newName: "LastUpdateBy");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "CreditCard",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "credit_card_number",
                table: "CreditCard",
                newName: "CreditCardNumber");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "CreditCard",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "create_by",
                table: "CreditCard",
                newName: "CreateBy");

            migrationBuilder.RenameIndex(
                name: "ix_credit_card_employee_id",
                table: "CreditCard",
                newName: "IX_CreditCard_EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Spend",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "Spend",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Spend",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpentOn",
                table: "SpendingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "SpendingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "SpendingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "CreditCard",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreditCardNumber",
                table: "CreditCard",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "CreditCard",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spend",
                table: "Spend",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpendingDetails",
                table: "SpendingDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_Employees_EmployeeId",
                table: "CreditCard",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend",
                column: "IncomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend",
                column: "OutcomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpendingDetails_Employees_EmployeeId",
                table: "SpendingDetails",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
