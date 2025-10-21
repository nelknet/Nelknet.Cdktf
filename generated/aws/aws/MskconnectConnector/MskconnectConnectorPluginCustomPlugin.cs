using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorPluginCustomPlugin")]
    public class MskconnectConnectorPluginCustomPlugin : aws.MskconnectConnector.IMskconnectConnectorPluginCustomPlugin
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#arn MskconnectConnector#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#revision MskconnectConnector#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public double Revision
        {
            get;
            set;
        }
    }
}
