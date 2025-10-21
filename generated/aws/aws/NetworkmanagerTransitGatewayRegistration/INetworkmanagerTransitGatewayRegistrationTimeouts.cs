using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerTransitGatewayRegistration
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerTransitGatewayRegistrationTimeouts), fullyQualifiedName: "aws.networkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistrationTimeouts")]
    public interface INetworkmanagerTransitGatewayRegistrationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#create NetworkmanagerTransitGatewayRegistration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#delete NetworkmanagerTransitGatewayRegistration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerTransitGatewayRegistrationTimeouts), fullyQualifiedName: "aws.networkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistrationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerTransitGatewayRegistration.INetworkmanagerTransitGatewayRegistrationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#create NetworkmanagerTransitGatewayRegistration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#delete NetworkmanagerTransitGatewayRegistration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
