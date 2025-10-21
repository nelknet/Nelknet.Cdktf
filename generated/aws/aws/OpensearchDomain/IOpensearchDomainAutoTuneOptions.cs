using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAutoTuneOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAutoTuneOptions")]
    public interface IOpensearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        string DesiredState
        {
            get;
        }

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#maintenance_schedule OpensearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaintenanceSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#rollback_on_disable OpensearchDomain#rollback_on_disable}.</summary>
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RollbackOnDisable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#use_off_peak_window OpensearchDomain#use_off_peak_window}.</summary>
        [JsiiProperty(name: "useOffPeakWindow", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseOffPeakWindow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAutoTuneOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAutoTuneOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
            [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
            public string DesiredState
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>maintenance_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#maintenance_schedule OpensearchDomain#maintenance_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaintenanceSchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#rollback_on_disable OpensearchDomain#rollback_on_disable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RollbackOnDisable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#use_off_peak_window OpensearchDomain#use_off_peak_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useOffPeakWindow", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseOffPeakWindow
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
