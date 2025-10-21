using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfiguration), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfiguration")]
    public interface IQuicksightThemeConfiguration
    {
        /// <summary>data_color_palette block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#data_color_palette QuicksightTheme#data_color_palette}
        /// </remarks>
        [JsiiProperty(name: "dataColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette? DataColorPalette
        {
            get
            {
                return null;
            }
        }

        /// <summary>sheet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#sheet QuicksightTheme#sheet}
        /// </remarks>
        [JsiiProperty(name: "sheet", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheet? Sheet
        {
            get
            {
                return null;
            }
        }

        /// <summary>typography block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#typography QuicksightTheme#typography}
        /// </remarks>
        [JsiiProperty(name: "typography", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationTypography? Typography
        {
            get
            {
                return null;
            }
        }

        /// <summary>ui_color_palette block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#ui_color_palette QuicksightTheme#ui_color_palette}
        /// </remarks>
        [JsiiProperty(name: "uiColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette? UiColorPalette
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfiguration), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_color_palette block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#data_color_palette QuicksightTheme#data_color_palette}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationDataColorPalette\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette? DataColorPalette
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationDataColorPalette?>();
            }

            /// <summary>sheet block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#sheet QuicksightTheme#sheet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sheet", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheet\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheet? Sheet
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheet?>();
            }

            /// <summary>typography block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#typography QuicksightTheme#typography}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typography", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationTypography? Typography
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationTypography?>();
            }

            /// <summary>ui_color_palette block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#ui_color_palette QuicksightTheme#ui_color_palette}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uiColorPalette", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationUiColorPalette\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette? UiColorPalette
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationUiColorPalette?>();
            }
        }
    }
}
