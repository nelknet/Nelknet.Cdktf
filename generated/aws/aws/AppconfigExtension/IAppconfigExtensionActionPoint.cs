using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppconfigExtension
{
    [JsiiInterface(nativeType: typeof(IAppconfigExtensionActionPoint), fullyQualifiedName: "aws.appconfigExtension.AppconfigExtensionActionPoint")]
    public interface IAppconfigExtensionActionPoint
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#action AppconfigExtension#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appconfigExtension.AppconfigExtensionActionPointAction\"},\"kind\":\"array\"}}]}}")]
        object Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#point AppconfigExtension#point}.</summary>
        [JsiiProperty(name: "point", typeJson: "{\"primitive\":\"string\"}")]
        string Point
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppconfigExtensionActionPoint), fullyQualifiedName: "aws.appconfigExtension.AppconfigExtensionActionPoint")]
        internal sealed class _Proxy : DeputyBase, aws.AppconfigExtension.IAppconfigExtensionActionPoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#action AppconfigExtension#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appconfigExtension.AppconfigExtensionActionPointAction\"},\"kind\":\"array\"}}]}}")]
            public object Action
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#point AppconfigExtension#point}.</summary>
            [JsiiProperty(name: "point", typeJson: "{\"primitive\":\"string\"}")]
            public string Point
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
