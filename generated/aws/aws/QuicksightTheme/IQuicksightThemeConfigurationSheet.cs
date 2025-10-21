using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationSheet), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheet")]
    public interface IQuicksightThemeConfigurationSheet
    {
        /// <summary>tile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile QuicksightTheme#tile}
        /// </remarks>
        [JsiiProperty(name: "tile", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile? Tile
        {
            get
            {
                return null;
            }
        }

        /// <summary>tile_layout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile_layout QuicksightTheme#tile_layout}
        /// </remarks>
        [JsiiProperty(name: "tileLayout", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout? TileLayout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationSheet), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheet")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationSheet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile QuicksightTheme#tile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tile", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTile\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile? Tile
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTile?>();
            }

            /// <summary>tile_layout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tile_layout QuicksightTheme#tile_layout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tileLayout", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationSheetTileLayout\"}", isOptional: true)]
            public aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout? TileLayout
            {
                get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileLayout?>();
            }
        }
    }
}
