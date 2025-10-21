using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeSelfHosted
{
    [JsiiInterface(nativeType: typeof(IDataFactoryIntegrationRuntimeSelfHostedRbacAuthorization), fullyQualifiedName: "azurerm.dataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedRbacAuthorization")]
    public interface IDataFactoryIntegrationRuntimeSelfHostedRbacAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#resource_id DataFactoryIntegrationRuntimeSelfHosted#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryIntegrationRuntimeSelfHostedRbacAuthorization), fullyQualifiedName: "azurerm.dataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedRbacAuthorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryIntegrationRuntimeSelfHosted.IDataFactoryIntegrationRuntimeSelfHostedRbacAuthorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#resource_id DataFactoryIntegrationRuntimeSelfHosted#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
