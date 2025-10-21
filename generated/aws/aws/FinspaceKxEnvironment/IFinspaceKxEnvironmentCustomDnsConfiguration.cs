using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxEnvironmentCustomDnsConfiguration), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentCustomDnsConfiguration")]
    public interface IFinspaceKxEnvironmentCustomDnsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_ip FinspaceKxEnvironment#custom_dns_server_ip}.</summary>
        [JsiiProperty(name: "customDnsServerIp", typeJson: "{\"primitive\":\"string\"}")]
        string CustomDnsServerIp
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_name FinspaceKxEnvironment#custom_dns_server_name}.</summary>
        [JsiiProperty(name: "customDnsServerName", typeJson: "{\"primitive\":\"string\"}")]
        string CustomDnsServerName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxEnvironmentCustomDnsConfiguration), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentCustomDnsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentCustomDnsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_ip FinspaceKxEnvironment#custom_dns_server_ip}.</summary>
            [JsiiProperty(name: "customDnsServerIp", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomDnsServerIp
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_name FinspaceKxEnvironment#custom_dns_server_name}.</summary>
            [JsiiProperty(name: "customDnsServerName", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomDnsServerName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
