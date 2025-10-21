using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OamLink
{
    [JsiiInterface(nativeType: typeof(IOamLinkLinkConfigurationLogGroupConfiguration), fullyQualifiedName: "aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration")]
    public interface IOamLinkLinkConfigurationLogGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#filter OamLink#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOamLinkLinkConfigurationLogGroupConfiguration), fullyQualifiedName: "aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#filter OamLink#filter}.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
