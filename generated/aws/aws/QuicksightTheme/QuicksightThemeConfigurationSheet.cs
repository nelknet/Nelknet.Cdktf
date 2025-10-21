using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationSheet")]
    public class QuicksightThemeConfigurationSheet : aws.QuicksightTheme.IQuicksightThemeConfigurationSheet
    {
        /// <summary>tile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile QuicksightTheme#tile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tile", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile? Tile
        {
            get;
            set;
        }

        /// <summary>tile_layout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile_layout QuicksightTheme#tile_layout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tileLayout", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout? TileLayout
        {
            get;
            set;
        }
    }
}
