using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#instance_url AppflowConnectorProfile#instance_url}.</summary>
        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesServiceNow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#instance_url AppflowConnectorProfile#instance_url}.</summary>
            [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
