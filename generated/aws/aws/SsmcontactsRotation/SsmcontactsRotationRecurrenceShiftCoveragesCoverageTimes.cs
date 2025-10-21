using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes")]
    public class SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes
    {
        private object? _end;

        /// <summary>end block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#end SsmcontactsRotation#end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesEnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? End
        {
            get => _end;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesEnd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesEnd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _end = value;
            }
        }

        private object? _start;

        /// <summary>start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#start SsmcontactsRotation#start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Start
        {
            get => _start;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _start = value;
            }
        }
    }
}
