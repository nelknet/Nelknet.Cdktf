using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiClass(nativeType: typeof(aws.EcsCluster.EcsClusterConfigurationOutputReference), fullyQualifiedName: "aws.ecsCluster.EcsClusterConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsClusterConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsClusterConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsClusterConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsClusterConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExecuteCommandConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration\"}}]")]
        public virtual void PutExecuteCommandConfiguration(aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedStorageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationManagedStorageConfiguration\"}}]")]
        public virtual void PutManagedStorageConfiguration(aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExecuteCommandConfiguration")]
        public virtual void ResetExecuteCommandConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedStorageConfiguration")]
        public virtual void ResetManagedStorageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "executeCommandConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfigurationOutputReference\"}")]
        public virtual aws.EcsCluster.EcsClusterConfigurationExecuteCommandConfigurationOutputReference ExecuteCommandConfiguration
        {
            get => GetInstanceProperty<aws.EcsCluster.EcsClusterConfigurationExecuteCommandConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "managedStorageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationManagedStorageConfigurationOutputReference\"}")]
        public virtual aws.EcsCluster.EcsClusterConfigurationManagedStorageConfigurationOutputReference ManagedStorageConfiguration
        {
            get => GetInstanceProperty<aws.EcsCluster.EcsClusterConfigurationManagedStorageConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeCommandConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationExecuteCommandConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration? ExecuteCommandConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsCluster.IEcsClusterConfigurationExecuteCommandConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedStorageConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfigurationManagedStorageConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration? ManagedStorageConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsCluster.IEcsClusterConfigurationManagedStorageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCluster.EcsClusterConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCluster.IEcsClusterConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCluster.IEcsClusterConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
