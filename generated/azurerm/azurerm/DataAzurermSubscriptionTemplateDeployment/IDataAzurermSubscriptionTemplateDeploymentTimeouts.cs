using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSubscriptionTemplateDeployment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSubscriptionTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeploymentTimeouts")]
    public interface IDataAzurermSubscriptionTemplateDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment#read DataAzurermSubscriptionTemplateDeployment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSubscriptionTemplateDeploymentTimeouts), fullyQualifiedName: "azurerm.dataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeploymentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSubscriptionTemplateDeployment.IDataAzurermSubscriptionTemplateDeploymentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment#read DataAzurermSubscriptionTemplateDeployment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
