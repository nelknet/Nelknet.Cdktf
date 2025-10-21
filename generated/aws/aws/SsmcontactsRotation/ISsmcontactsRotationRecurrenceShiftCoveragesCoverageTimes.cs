using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes")]
    public interface ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes
    {
        /// <summary>end block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#end SsmcontactsRotation#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesEnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#start SsmcontactsRotation#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>end block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#end SsmcontactsRotation#end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesEnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? End
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>start block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#start SsmcontactsRotation#start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Start
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
