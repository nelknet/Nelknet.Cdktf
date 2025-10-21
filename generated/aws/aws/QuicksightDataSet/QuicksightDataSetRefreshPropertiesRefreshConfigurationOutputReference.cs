using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSetRefreshPropertiesRefreshConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIncrementalRefresh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh\"}}]")]
        public virtual void PutIncrementalRefresh(aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh)}, new object[]{@value});
        }

        [JsiiProperty(name: "incrementalRefresh", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshOutputReference IncrementalRefresh
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "incrementalRefreshInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh? IncrementalRefreshInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
