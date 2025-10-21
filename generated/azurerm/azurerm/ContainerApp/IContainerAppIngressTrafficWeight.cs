using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppIngressTrafficWeight), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngressTrafficWeight")]
    public interface IContainerAppIngressTrafficWeight
    {
        /// <summary>The percentage of traffic to send to this revision.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#percentage ContainerApp#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        double Percentage
        {
            get;
        }

        /// <summary>The label to apply to the revision as a name prefix for routing traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#label ContainerApp#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>This traffic Weight relates to the latest stable Container Revision.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#latest_revision ContainerApp#latest_revision}
        /// </remarks>
        [JsiiProperty(name: "latestRevision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LatestRevision
        {
            get
            {
                return null;
            }
        }

        /// <summary>The suffix string to append to the revision.</summary>
        /// <remarks>
        /// This must be unique for the Container App's lifetime. A default hash created by the service will be used if this value is omitted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#revision_suffix ContainerApp#revision_suffix}
        /// </remarks>
        [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RevisionSuffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppIngressTrafficWeight), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngressTrafficWeight")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppIngressTrafficWeight
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The percentage of traffic to send to this revision.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#percentage ContainerApp#percentage}
            /// </remarks>
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
            public double Percentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The label to apply to the revision as a name prefix for routing traffic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#label ContainerApp#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This traffic Weight relates to the latest stable Container Revision.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#latest_revision ContainerApp#latest_revision}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latestRevision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LatestRevision
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The suffix string to append to the revision.</summary>
            /// <remarks>
            /// This must be unique for the Container App's lifetime. A default hash created by the service will be used if this value is omitted.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#revision_suffix ContainerApp#revision_suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RevisionSuffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
