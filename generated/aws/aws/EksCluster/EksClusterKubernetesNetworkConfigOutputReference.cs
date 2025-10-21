using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubernetesNetworkConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubernetesNetworkConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubernetesNetworkConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubernetesNetworkConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterKubernetesNetworkConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubernetesNetworkConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putElasticLoadBalancing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancing\"}}]")]
        public virtual void PutElasticLoadBalancing(aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetElasticLoadBalancing")]
        public virtual void ResetElasticLoadBalancing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpFamily")]
        public virtual void ResetIpFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceIpv4Cidr")]
        public virtual void ResetServiceIpv4Cidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "elasticLoadBalancing", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancingOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancingOutputReference ElasticLoadBalancing
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancingOutputReference>()!;
        }

        [JsiiProperty(name: "serviceIpv6Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv6Cidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticLoadBalancingInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigElasticLoadBalancing\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing? ElasticLoadBalancingInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubernetesNetworkConfigElasticLoadBalancing?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv4CidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceIpv4CidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ipFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv4Cidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubernetesNetworkConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubernetesNetworkConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
