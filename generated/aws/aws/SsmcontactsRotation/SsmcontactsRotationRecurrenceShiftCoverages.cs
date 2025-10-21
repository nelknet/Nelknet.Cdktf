using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages")]
    public class SsmcontactsRotationRecurrenceShiftCoverages : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#map_block_key SsmcontactsRotation#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        public string MapBlockKey
        {
            get;
            set;
        }

        private object? _coverageTimes;

        /// <summary>coverage_times block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#coverage_times SsmcontactsRotation#coverage_times}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coverageTimes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CoverageTimes
        {
            get => _coverageTimes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _coverageTimes = value;
            }
        }
    }
}
