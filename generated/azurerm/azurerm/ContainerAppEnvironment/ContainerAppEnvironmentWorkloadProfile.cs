using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppEnvironment.ContainerAppEnvironmentWorkloadProfile")]
    public class ContainerAppEnvironmentWorkloadProfile : azurerm.ContainerAppEnvironment.IContainerAppEnvironmentWorkloadProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#name ContainerAppEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#workload_profile_type ContainerAppEnvironment#workload_profile_type}.</summary>
        [JsiiProperty(name: "workloadProfileType", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkloadProfileType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#maximum_count ContainerAppEnvironment#maximum_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#minimum_count ContainerAppEnvironment#minimum_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumCount
        {
            get;
            set;
        }
    }
}
