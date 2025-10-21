using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppIngressTrafficWeight")]
    public class ContainerAppIngressTrafficWeight : azurerm.ContainerApp.IContainerAppIngressTrafficWeight
    {
        /// <summary>The percentage of traffic to send to this revision.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#percentage ContainerApp#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        public double Percentage
        {
            get;
            set;
        }

        /// <summary>The label to apply to the revision as a name prefix for routing traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#label ContainerApp#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        private object? _latestRevision;

        /// <summary>This traffic Weight relates to the latest stable Container Revision.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#latest_revision ContainerApp#latest_revision}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latestRevision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LatestRevision
        {
            get => _latestRevision;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _latestRevision = value;
            }
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
            get;
            set;
        }
    }
}
