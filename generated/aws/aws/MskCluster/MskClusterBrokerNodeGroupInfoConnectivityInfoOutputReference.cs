using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterBrokerNodeGroupInfoConnectivityInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublicAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess\"}}]")]
        public virtual void PutPublicAccess(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConnectivity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity\"}}]")]
        public virtual void PutVpcConnectivity(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublicAccess")]
        public virtual void ResetPublicAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConnectivity")]
        public virtual void ResetVpcConnectivity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publicAccess", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccessOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccessOutputReference PublicAccess
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccessOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConnectivity", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityOutputReference VpcConnectivity
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicAccessInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccessInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoPublicAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConnectivityInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity? VpcConnectivityInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
