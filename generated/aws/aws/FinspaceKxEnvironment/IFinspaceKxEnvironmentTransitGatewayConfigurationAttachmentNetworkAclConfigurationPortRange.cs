using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange")]
    public interface IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#from FinspaceKxEnvironment#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}")]
        double From
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#to FinspaceKxEnvironment#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}")]
        double To
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#from FinspaceKxEnvironment#from}.</summary>
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}")]
            public double From
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#to FinspaceKxEnvironment#to}.</summary>
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}")]
            public double To
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
