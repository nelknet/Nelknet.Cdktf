using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeResourceConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource), fullyQualifiedName: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource")]
    public interface IVpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#ip_address VpclatticeResourceConfiguration#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource), fullyQualifiedName: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeResourceConfiguration.IVpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#ip_address VpclatticeResourceConfiguration#ip_address}.</summary>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
