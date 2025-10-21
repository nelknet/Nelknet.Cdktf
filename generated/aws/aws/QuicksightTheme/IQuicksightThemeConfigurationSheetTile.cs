using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationSheetTile), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTile")]
    public interface IQuicksightThemeConfigurationSheetTile
    {
        /// <summary>border block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#border QuicksightTheme#border}
        /// </remarks>
        [JsiiProperty(name: "border", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder? Border
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationSheetTile), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTile")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>border block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#border QuicksightTheme#border}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "border", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder? Border
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder?>();
            }
        }
    }
}
