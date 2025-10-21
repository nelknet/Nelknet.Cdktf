using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IotSecuritySolution
{
    [JsiiInterface(nativeType: typeof(IIotSecuritySolutionAdditionalWorkspace), fullyQualifiedName: "azurerm.iotSecuritySolution.IotSecuritySolutionAdditionalWorkspace")]
    public interface IIotSecuritySolutionAdditionalWorkspace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#data_types IotSecuritySolution#data_types}.</summary>
        [JsiiProperty(name: "dataTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DataTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#workspace_id IotSecuritySolution#workspace_id}.</summary>
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkspaceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotSecuritySolutionAdditionalWorkspace), fullyQualifiedName: "azurerm.iotSecuritySolution.IotSecuritySolutionAdditionalWorkspace")]
        internal sealed class _Proxy : DeputyBase, azurerm.IotSecuritySolution.IIotSecuritySolutionAdditionalWorkspace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#data_types IotSecuritySolution#data_types}.</summary>
            [JsiiProperty(name: "dataTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DataTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#workspace_id IotSecuritySolution#workspace_id}.</summary>
            [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
