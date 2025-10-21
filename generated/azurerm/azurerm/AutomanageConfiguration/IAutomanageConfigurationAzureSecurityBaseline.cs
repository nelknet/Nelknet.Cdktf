using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomanageConfigurationAzureSecurityBaseline), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationAzureSecurityBaseline")]
    public interface IAutomanageConfigurationAzureSecurityBaseline
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#assignment_type AutomanageConfiguration#assignment_type}.</summary>
        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssignmentType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomanageConfigurationAzureSecurityBaseline), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationAzureSecurityBaseline")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomanageConfiguration.IAutomanageConfigurationAzureSecurityBaseline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#assignment_type AutomanageConfiguration#assignment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssignmentType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
