using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiClass(nativeType: typeof(aws.AppmeshMesh.AppmeshMeshSpecOutputReference), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshMeshSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshMeshSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshMeshSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshMeshSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEgressFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilter\"}}]")]
        public virtual void PutEgressFilter(aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceDiscovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery\"}}]")]
        public virtual void PutServiceDiscovery(aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEgressFilter")]
        public virtual void ResetEgressFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceDiscovery")]
        public virtual void ResetServiceDiscovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilterOutputReference\"}")]
        public virtual aws.AppmeshMesh.AppmeshMeshSpecEgressFilterOutputReference EgressFilter
        {
            get => GetInstanceProperty<aws.AppmeshMesh.AppmeshMeshSpecEgressFilterOutputReference>()!;
        }

        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscoveryOutputReference\"}")]
        public virtual aws.AppmeshMesh.AppmeshMeshSpecServiceDiscoveryOutputReference ServiceDiscovery
        {
            get => GetInstanceProperty<aws.AppmeshMesh.AppmeshMeshSpecServiceDiscoveryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressFilterInput", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        public virtual aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter? EgressFilterInput
        {
            get => GetInstanceProperty<aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceDiscoveryInput", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery\"}", isOptional: true)]
        public virtual aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery? ServiceDiscoveryInput
        {
            get => GetInstanceProperty<aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpec\"}", isOptional: true)]
        public virtual aws.AppmeshMesh.IAppmeshMeshSpec? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshMesh.IAppmeshMeshSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
