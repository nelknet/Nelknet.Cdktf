using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesOutputReference), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHadoopClusterRolesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHadoopClusterRolesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHadoopClusterRolesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopClusterRolesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEdgeNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode\"}}]")]
        public virtual void PutEdgeNode(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeadNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNode\"}}]")]
        public virtual void PutHeadNode(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNode\"}}]")]
        public virtual void PutWorkerNode(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZookeeperNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNode\"}}]")]
        public virtual void PutZookeeperNode(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEdgeNode")]
        public virtual void ResetEdgeNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeOutputReference EdgeNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeOutputReference>()!;
        }

        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNodeOutputReference HeadNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNodeOutputReference>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeOutputReference WorkerNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNodeOutputReference\"}")]
        public virtual azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNodeOutputReference ZookeeperNode
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode? EdgeNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode? HeadNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode? WorkerNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zookeeperNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode? ZookeeperNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles?>();
            set => SetInstanceProperty(value);
        }
    }
}
