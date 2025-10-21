using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironment
{
    [JsiiInterface(nativeType: typeof(IContainerAppEnvironmentWorkloadProfile), fullyQualifiedName: "azurerm.containerAppEnvironment.ContainerAppEnvironmentWorkloadProfile")]
    public interface IContainerAppEnvironmentWorkloadProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#name ContainerAppEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#workload_profile_type ContainerAppEnvironment#workload_profile_type}.</summary>
        [JsiiProperty(name: "workloadProfileType", typeJson: "{\"primitive\":\"string\"}")]
        string WorkloadProfileType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#maximum_count ContainerAppEnvironment#maximum_count}.</summary>
        [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#minimum_count ContainerAppEnvironment#minimum_count}.</summary>
        [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppEnvironmentWorkloadProfile), fullyQualifiedName: "azurerm.containerAppEnvironment.ContainerAppEnvironmentWorkloadProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppEnvironment.IContainerAppEnvironmentWorkloadProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#name ContainerAppEnvironment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#workload_profile_type ContainerAppEnvironment#workload_profile_type}.</summary>
            [JsiiProperty(name: "workloadProfileType", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkloadProfileType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#maximum_count ContainerAppEnvironment#maximum_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#minimum_count ContainerAppEnvironment#minimum_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
