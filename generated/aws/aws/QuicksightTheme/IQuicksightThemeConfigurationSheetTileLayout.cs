using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationSheetTileLayout), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout")]
    public interface IQuicksightThemeConfigurationSheetTileLayout
    {
        /// <summary>gutter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#gutter QuicksightTheme#gutter}
        /// </remarks>
        [JsiiProperty(name: "gutter", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter? Gutter
        {
            get
            {
                return null;
            }
        }

        /// <summary>margin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#margin QuicksightTheme#margin}
        /// </remarks>
        [JsiiProperty(name: "margin", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMargin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin? Margin
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationSheetTileLayout), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>gutter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#gutter QuicksightTheme#gutter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gutter", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutGutter\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter? Gutter
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutGutter?>();
            }

            /// <summary>margin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#margin QuicksightTheme#margin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "margin", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayoutMargin\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin? Margin
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayoutMargin?>();
            }
        }
    }
}
