using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiByValue(fqn: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer : azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#availability_set_name WorkloadsSapThreeTierVirtualInstance#availability_set_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilitySetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilitySetName
        {
            get;
            set;
        }

        private object? _virtualMachine;

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#virtual_machine WorkloadsSapThreeTierVirtualInstance#virtual_machine}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachine
        {
            get => _virtualMachine;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachine = value;
            }
        }
    }
}
