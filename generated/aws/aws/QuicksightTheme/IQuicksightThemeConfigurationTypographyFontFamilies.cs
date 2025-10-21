using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationTypographyFontFamilies), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies")]
    public interface IQuicksightThemeConfigurationTypographyFontFamilies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_family QuicksightTheme#font_family}.</summary>
        [JsiiProperty(name: "fontFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FontFamily
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationTypographyFontFamilies), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_family QuicksightTheme#font_family}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fontFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FontFamily
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
