using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookACar.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescription_Cars_CarID",
                table: "CarDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeature_Cars_CarID",
                table: "CarFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeature_Feature_FeatureID",
                table: "CarFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature",
                table: "Feature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarFeature",
                table: "CarFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "Features");

            migrationBuilder.RenameTable(
                name: "CarFeature",
                newName: "CarFeatures");

            migrationBuilder.RenameTable(
                name: "CarDescription",
                newName: "CarDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeature_FeatureID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_FeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeature_CarID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescription_CarID",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "FeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarFeatures",
                table: "CarFeatures",
                column: "CarFeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions",
                column: "CarDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Features_FeatureID",
                table: "CarFeatures",
                column: "FeatureID",
                principalTable: "Features",
                principalColumn: "FeatureID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Features_FeatureID",
                table: "CarFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarFeatures",
                table: "CarFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "Feature");

            migrationBuilder.RenameTable(
                name: "CarFeatures",
                newName: "CarFeature");

            migrationBuilder.RenameTable(
                name: "CarDescriptions",
                newName: "CarDescription");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_FeatureID",
                table: "CarFeature",
                newName: "IX_CarFeature_FeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeature",
                newName: "IX_CarFeature_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescription",
                newName: "IX_CarDescription_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature",
                table: "Feature",
                column: "FeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarFeature",
                table: "CarFeature",
                column: "CarFeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription",
                column: "CarDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescription_Cars_CarID",
                table: "CarDescription",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeature_Cars_CarID",
                table: "CarFeature",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeature_Feature_FeatureID",
                table: "CarFeature",
                column: "FeatureID",
                principalTable: "Feature",
                principalColumn: "FeatureID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
