using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallTlsInspectionConfiguration
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination), fullyQualifiedName: "aws.networkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination")]
    public interface INetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#address_definition NetworkfirewallTlsInspectionConfiguration#address_definition}.</summary>
        [JsiiProperty(name: "addressDefinition", typeJson: "{\"primitive\":\"string\"}")]
        string AddressDefinition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination), fullyQualifiedName: "aws.networkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallTlsInspectionConfiguration.INetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationServerCertificateConfigurationScopeDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#address_definition NetworkfirewallTlsInspectionConfiguration#address_definition}.</summary>
            [JsiiProperty(name: "addressDefinition", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressDefinition
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
