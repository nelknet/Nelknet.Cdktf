using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationDataColorPalette), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette")]
    public interface IQuicksightThemeConfigurationDataColorPalette
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#colors QuicksightTheme#colors}.</summary>
        [JsiiProperty(name: "colors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Colors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#empty_fill_color QuicksightTheme#empty_fill_color}.</summary>
        [JsiiProperty(name: "emptyFillColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmptyFillColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#min_max_gradient QuicksightTheme#min_max_gradient}.</summary>
        [JsiiProperty(name: "minMaxGradient", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MinMaxGradient
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationDataColorPalette), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#colors QuicksightTheme#colors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "colors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Colors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#empty_fill_color QuicksightTheme#empty_fill_color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emptyFillColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmptyFillColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#min_max_gradient QuicksightTheme#min_max_gradient}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minMaxGradient", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MinMaxGradient
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
