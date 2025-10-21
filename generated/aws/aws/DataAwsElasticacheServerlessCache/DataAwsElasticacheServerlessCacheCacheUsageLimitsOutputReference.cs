using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheServerlessCache
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference), fullyQualifiedName: "aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheServerlessCacheCacheUsageLimitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dataStorage", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsDataStorageOutputReference\"}")]
        public virtual aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsDataStorageOutputReference DataStorage
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsDataStorageOutputReference>()!;
        }

        [JsiiProperty(name: "ecpuPerSecond", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference\"}")]
        public virtual aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference EcpuPerSecond
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecondOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheServerlessCache.DataAwsElasticacheServerlessCacheCacheUsageLimits\"}", isOptional: true)]
        public virtual aws.DataAwsElasticacheServerlessCache.IDataAwsElasticacheServerlessCacheCacheUsageLimits? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheServerlessCache.IDataAwsElasticacheServerlessCacheCacheUsageLimits?>();
            set => SetInstanceProperty(value);
        }
    }
}
