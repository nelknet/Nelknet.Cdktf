using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesOutputReference), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightSparkClusterRolesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightSparkClusterRolesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightSparkClusterRolesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightSparkClusterRolesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHeadNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesHeadNode\"}}]")]
        public virtual void PutHeadNode(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNode\"}}]")]
        public virtual void PutWorkerNode(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZookeeperNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNode\"}}]")]
        public virtual void PutZookeeperNode(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode)}, new object[]{@value});
        }

        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesHeadNodeOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesHeadNodeOutputReference HeadNode
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesHeadNodeOutputReference>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeOutputReference WorkerNode
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNodeOutputReference\"}")]
        public virtual azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNodeOutputReference ZookeeperNode
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesHeadNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode? HeadNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode? WorkerNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zookeeperNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode? ZookeeperNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles?>();
            set => SetInstanceProperty(value);
        }
    }
}
