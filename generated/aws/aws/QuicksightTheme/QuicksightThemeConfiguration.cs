using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfiguration")]
    public class QuicksightThemeConfiguration : aws.QuicksightTheme.IQuicksightThemeConfiguration
    {
        /// <summary>data_color_palette block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#data_color_palette QuicksightTheme#data_color_palette}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette? DataColorPalette
        {
            get;
            set;
        }

        /// <summary>sheet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#sheet QuicksightTheme#sheet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sheet", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationSheet? Sheet
        {
            get;
            set;
        }

        /// <summary>typography block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#typography QuicksightTheme#typography}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "typography", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationTypography? Typography
        {
            get;
            set;
        }

        /// <summary>ui_color_palette block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#ui_color_palette QuicksightTheme#ui_color_palette}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uiColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
        public aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette? UiColorPalette
        {
            get;
            set;
        }
    }
}
