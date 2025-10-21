using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlacierVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glacierVault.GlacierVaultNotification")]
    public class GlacierVaultNotification : aws.GlacierVault.IGlacierVaultNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#events GlacierVault#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Events
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsTopic
        {
            get;
            set;
        }
    }
}
