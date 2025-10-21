using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksApplication
{
    [JsiiInterface(nativeType: typeof(IOpsworksApplicationSslConfiguration), fullyQualifiedName: "aws.opsworksApplication.OpsworksApplicationSslConfiguration")]
    public interface IOpsworksApplicationSslConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#certificate OpsworksApplication#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        string Certificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#private_key OpsworksApplication#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#chain OpsworksApplication#chain}.</summary>
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Chain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksApplicationSslConfiguration), fullyQualifiedName: "aws.opsworksApplication.OpsworksApplicationSslConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksApplication.IOpsworksApplicationSslConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#certificate OpsworksApplication#certificate}.</summary>
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
            public string Certificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#private_key OpsworksApplication#private_key}.</summary>
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#chain OpsworksApplication#chain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Chain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
