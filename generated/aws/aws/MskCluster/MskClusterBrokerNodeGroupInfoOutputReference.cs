using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterBrokerNodeGroupInfoOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterBrokerNodeGroupInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterBrokerNodeGroupInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterBrokerNodeGroupInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterBrokerNodeGroupInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectivityInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo\"}}]")]
        public virtual void PutConnectivityInfo(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo\"}}]")]
        public virtual void PutStorageInfo(aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzDistribution")]
        public virtual void ResetAzDistribution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectivityInfo")]
        public virtual void ResetConnectivityInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageInfo")]
        public virtual void ResetStorageInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectivityInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference ConnectivityInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference>()!;
        }

        [JsiiProperty(name: "storageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoStorageInfoOutputReference StorageInfo
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoStorageInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azDistributionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzDistributionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSubnetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClientSubnetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageInfoInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo? StorageInfoInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo?>();
        }

        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzDistribution
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientSubnets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfo? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
