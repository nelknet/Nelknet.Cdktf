using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiInterface(nativeType: typeof(IQuicksightThemeConfigurationSheetTileBorder), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder")]
    public interface IQuicksightThemeConfigurationSheetTileBorder
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#show QuicksightTheme#show}.</summary>
        [JsiiProperty(name: "show", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Show
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightThemeConfigurationSheetTileBorder), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationSheetTileBorder")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTheme.IQuicksightThemeConfigurationSheetTileBorder
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#show QuicksightTheme#show}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "show", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Show
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
