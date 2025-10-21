using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    [JsiiClass(nativeType: typeof(aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderOutputReference), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrcontainersVirtualClusterContainerProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrcontainersVirtualClusterContainerProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrcontainersVirtualClusterContainerProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrcontainersVirtualClusterContainerProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo\"}}]")]
        public virtual void PutInfo(aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo)}, new object[]{@value});
        }

        [JsiiProperty(name: "info", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoOutputReference\"}")]
        public virtual aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoOutputReference Info
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infoInput", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo\"}", isOptional: true)]
        public virtual aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo? InfoInput
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProvider\"}", isOptional: true)]
        public virtual aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProvider? InternalValue
        {
            get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
