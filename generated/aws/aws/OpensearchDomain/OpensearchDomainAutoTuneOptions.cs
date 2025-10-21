using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAutoTuneOptions")]
    public class OpensearchDomainAutoTuneOptions : aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public string DesiredState
        {
            get;
            set;
        }

        private object? _maintenanceSchedule;

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#maintenance_schedule OpensearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceSchedule
        {
            get => _maintenanceSchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceSchedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#rollback_on_disable OpensearchDomain#rollback_on_disable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RollbackOnDisable
        {
            get;
            set;
        }

        private object? _useOffPeakWindow;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#use_off_peak_window OpensearchDomain#use_off_peak_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useOffPeakWindow", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseOffPeakWindow
        {
            get => _useOffPeakWindow;
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
                _useOffPeakWindow = value;
            }
        }
    }
}
