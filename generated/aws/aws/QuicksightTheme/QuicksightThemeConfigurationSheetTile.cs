using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTile")]
    public class QuicksightThemeConfigurationSheetTile : aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile
    {
        /// <summary>border block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#border QuicksightTheme#border}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "border", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder? Border
        {
            get;
            set;
        }
    }
}
