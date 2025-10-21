using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies")]
    public class QuicksightThemeConfigurationTypographyFontFamilies : aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_family QuicksightTheme#font_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fontFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FontFamily
        {
            get;
            set;
        }
    }
}
