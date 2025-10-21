using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDashboard.QuicksightDashboardSourceEntityOutputReference), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDashboardSourceEntityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDashboardSourceEntityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDashboardSourceEntityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDashboardSourceEntityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourceTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate\"}}]")]
        public virtual void PutSourceTemplate(aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSourceTemplate")]
        public virtual void ResetSourceTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateOutputReference SourceTemplate
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplateInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate? SourceTemplateInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntity\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardSourceEntity? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardSourceEntity?>();
            set => SetInstanceProperty(value);
        }
    }
}
