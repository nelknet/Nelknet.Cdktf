using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheServerlessCache
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference), fullyQualifiedName: "aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Maximum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minimum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond\"}", isOptional: true)]
        public virtual aws.DataAwsElasticacheServerlessCache.IDataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheServerlessCache.IDataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond?>();
            set => SetInstanceProperty(value);
        }
    }
}
