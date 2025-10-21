using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorPlugin")]
    public class MskconnectConnectorPlugin : aws.MskconnectConnector.IMskconnectConnectorPlugin
    {
        /// <summary>custom_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#custom_plugin MskconnectConnector#custom_plugin}
        /// </remarks>
        [JsiiProperty(name: "customPlugin", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPluginCustomPlugin\"}")]
        public aws.MskconnectConnector.IMskconnectConnectorPluginCustomPlugin CustomPlugin
        {
            get;
            set;
        }
    }
}
