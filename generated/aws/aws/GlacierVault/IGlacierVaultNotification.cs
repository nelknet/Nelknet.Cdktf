using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlacierVault
{
    [JsiiInterface(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.glacierVault.GlacierVaultNotification")]
    public interface IGlacierVaultNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#events GlacierVault#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Events
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopic
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.glacierVault.GlacierVaultNotification")]
        internal sealed class _Proxy : DeputyBase, aws.GlacierVault.IGlacierVaultNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#events GlacierVault#events}.</summary>
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Events
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
            [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopic
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
