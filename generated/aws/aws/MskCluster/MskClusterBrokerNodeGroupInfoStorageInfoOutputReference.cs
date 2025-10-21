using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterBrokerNodeGroupInfoStorageInfoOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterBrokerNodeGroupInfoStorageInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterBrokerNodeGroupInfoStorageInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterBrokerNodeGroupInfoStorageInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterBrokerNodeGroupInfoStorageInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEbsStorageInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo\"}}]")]
        public virtual void PutEbsStorageInfo(aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEbsStorageInfo")]
        public virtual void ResetEbsStorageInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ebsStorageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoOutputReference EbsStorageInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsStorageInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
