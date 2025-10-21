using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationTypography), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationTypography")]
    public interface IQuicksightThemeConfigurationTypography
    {
        /// <summary>font_families block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_families QuicksightTheme#font_families}
        /// </remarks>
        [JsiiProperty(name: "fontFamilies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FontFamilies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationTypography), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationTypography")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationTypography
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>font_families block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_families QuicksightTheme#font_families}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fontFamilies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FontFamilies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
