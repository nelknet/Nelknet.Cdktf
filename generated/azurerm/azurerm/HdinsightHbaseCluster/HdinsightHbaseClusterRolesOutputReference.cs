using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesOutputReference), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHbaseClusterRolesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHbaseClusterRolesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHbaseClusterRolesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHbaseClusterRolesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHeadNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNode\"}}]")]
        public virtual void PutHeadNode(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNode\"}}]")]
        public virtual void PutWorkerNode(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZookeeperNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNode\"}}]")]
        public virtual void PutZookeeperNode(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode)}, new object[]{@value});
        }

        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNodeOutputReference HeadNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNodeOutputReference>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeOutputReference WorkerNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNodeOutputReference ZookeeperNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode? HeadNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode? WorkerNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zookeeperNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode? ZookeeperNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles?>();
            set => SetInstanceProperty(value);
        }
    }
}
