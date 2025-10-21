using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    [JsiiClass(nativeType: typeof(aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoOutputReference), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrcontainersVirtualClusterContainerProviderInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrcontainersVirtualClusterContainerProviderInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrcontainersVirtualClusterContainerProviderInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrcontainersVirtualClusterContainerProviderInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEksInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfo\"}}]")]
        public virtual void PutEksInfo(aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo)}, new object[]{@value});
        }

        [JsiiProperty(name: "eksInfo", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfoOutputReference\"}")]
        public virtual aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfoOutputReference EksInfo
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eksInfoInput", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfo\"}", isOptional: true)]
        public virtual aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo? EksInfoInput
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo\"}", isOptional: true)]
        public virtual aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo? InternalValue
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
