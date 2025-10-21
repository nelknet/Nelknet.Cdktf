using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSetRefreshPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSetRefreshPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSetRefreshPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetRefreshPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRefreshConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration\"}}]")]
        public virtual void PutRefreshConfiguration(aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration)}, new object[]{@value});
        }

        [JsiiProperty(name: "refreshConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference RefreshConfiguration
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshConfigurationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration? RefreshConfigurationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshProperties\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
