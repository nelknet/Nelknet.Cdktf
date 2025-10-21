using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette")]
    public class QuicksightThemeConfigurationDataColorPalette : aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#colors QuicksightTheme#colors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "colors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Colors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#empty_fill_color QuicksightTheme#empty_fill_color}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emptyFillColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmptyFillColor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#min_max_gradient QuicksightTheme#min_max_gradient}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minMaxGradient", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MinMaxGradient
        {
            get;
            set;
        }
    }
}
