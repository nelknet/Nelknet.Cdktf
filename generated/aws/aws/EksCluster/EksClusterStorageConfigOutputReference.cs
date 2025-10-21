using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterStorageConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterStorageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterStorageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterStorageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterStorageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterStorageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlockStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorage\"}}]")]
        public virtual void PutBlockStorage(aws.EksCluster.IEksClusterStorageConfigBlockStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterStorageConfigBlockStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockStorage")]
        public virtual void ResetBlockStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "blockStorage", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorageOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterStorageConfigBlockStorageOutputReference BlockStorage
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterStorageConfigBlockStorageOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockStorageInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorage\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterStorageConfigBlockStorage? BlockStorageInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterStorageConfigBlockStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterStorageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterStorageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
