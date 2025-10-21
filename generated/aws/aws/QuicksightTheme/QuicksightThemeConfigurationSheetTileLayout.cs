using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout")]
    public class QuicksightThemeConfigurationSheetTileLayout : aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout
    {
        /// <summary>gutter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#gutter QuicksightTheme#gutter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gutter", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutter\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter? Gutter
        {
            get;
            set;
        }

        /// <summary>margin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#margin QuicksightTheme#margin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "margin", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMargin\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin? Margin
        {
            get;
            set;
        }
    }
}
