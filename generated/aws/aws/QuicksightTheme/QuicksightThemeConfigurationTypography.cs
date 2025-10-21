using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiByValue(fqn: "aws.quicksightTheme.QuicksightThemeConfigurationTypography")]
    public class QuicksightThemeConfigurationTypography : aws.QuicksightTheme.IQuicksightThemeConfigurationTypography
    {
        private object? _fontFamilies;

        /// <summary>font_families block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#font_families QuicksightTheme#font_families}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fontFamilies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FontFamilies
        {
            get => _fontFamilies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fontFamilies = value;
            }
        }
    }
}
