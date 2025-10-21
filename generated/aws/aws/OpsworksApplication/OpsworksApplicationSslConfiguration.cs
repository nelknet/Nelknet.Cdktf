using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworksApplication.OpsworksApplicationSslConfiguration")]
    public class OpsworksApplicationSslConfiguration : aws.OpsworksApplication.IOpsworksApplicationSslConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#certificate OpsworksApplication#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public string Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#private_key OpsworksApplication#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#chain OpsworksApplication#chain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Chain
        {
            get;
            set;
        }
    }
}
