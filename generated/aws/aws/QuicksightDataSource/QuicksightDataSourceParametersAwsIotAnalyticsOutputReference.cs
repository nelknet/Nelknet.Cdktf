using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSource.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSourceParametersAwsIotAnalyticsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSourceParametersAwsIotAnalyticsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSourceParametersAwsIotAnalyticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersAwsIotAnalyticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics?>();
            set => SetInstanceProperty(value);
        }
    }
}
