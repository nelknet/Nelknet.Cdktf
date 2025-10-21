using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAvailabilityStatus")]
        public virtual void ResetAvailabilityStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption?>();
            set => SetInstanceProperty(value);
        }
    }
}
