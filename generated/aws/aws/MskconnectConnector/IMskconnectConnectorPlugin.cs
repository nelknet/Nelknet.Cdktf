using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorPlugin), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorPlugin")]
    public interface IMskconnectConnectorPlugin
    {
        /// <summary>custom_plugin block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#custom_plugin MskconnectConnector#custom_plugin}
        /// </remarks>
        [JsiiProperty(name: "customPlugin", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPluginCustomPlugin\"}")]
        aws.MskconnectConnector.IMskconnectConnectorPluginCustomPlugin CustomPlugin
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorPlugin), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorPlugin")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorPlugin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_plugin block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#custom_plugin MskconnectConnector#custom_plugin}
            /// </remarks>
            [JsiiProperty(name: "customPlugin", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorPluginCustomPlugin\"}")]
            public aws.MskconnectConnector.IMskconnectConnectorPluginCustomPlugin CustomPlugin
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorPluginCustomPlugin>()!;
            }
        }
    }
}
