using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    [JsiiInterface(nativeType: typeof(ISpringCloudGatewayClientAuthorization), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization")]
    public interface ISpringCloudGatewayClientAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#certificate_ids SpringCloudGateway#certificate_ids}.</summary>
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CertificateIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#verification_enabled SpringCloudGateway#verification_enabled}.</summary>
        [JsiiProperty(name: "verificationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerificationEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudGatewayClientAuthorization), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#certificate_ids SpringCloudGateway#certificate_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CertificateIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#verification_enabled SpringCloudGateway#verification_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verificationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VerificationEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
