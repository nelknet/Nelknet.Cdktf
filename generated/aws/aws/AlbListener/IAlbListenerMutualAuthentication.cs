using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListener
{
    [JsiiInterface(nativeType: typeof(IAlbListenerMutualAuthentication), fullyQualifiedName: "aws.albListener.AlbListenerMutualAuthentication")]
    public interface IAlbListenerMutualAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#mode AlbListener#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#advertise_trust_store_ca_names AlbListener#advertise_trust_store_ca_names}.</summary>
        [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdvertiseTrustStoreCaNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#ignore_client_certificate_expiry AlbListener#ignore_client_certificate_expiry}.</summary>
        [JsiiProperty(name: "ignoreClientCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreClientCertificateExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#trust_store_arn AlbListener#trust_store_arn}.</summary>
        [JsiiProperty(name: "trustStoreArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustStoreArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerMutualAuthentication), fullyQualifiedName: "aws.albListener.AlbListenerMutualAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.AlbListener.IAlbListenerMutualAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#mode AlbListener#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#advertise_trust_store_ca_names AlbListener#advertise_trust_store_ca_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdvertiseTrustStoreCaNames
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#ignore_client_certificate_expiry AlbListener#ignore_client_certificate_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreClientCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreClientCertificateExpiry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#trust_store_arn AlbListener#trust_store_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustStoreArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustStoreArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
