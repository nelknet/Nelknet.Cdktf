using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServicePlan
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppServicePlanTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppServicePlan.DataAzurermAppServicePlanTimeouts")]
    public interface IDataAzurermAppServicePlanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#read DataAzurermAppServicePlan#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppServicePlanTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppServicePlan.DataAzurermAppServicePlanTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppServicePlan.IDataAzurermAppServicePlanTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#read DataAzurermAppServicePlan#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
