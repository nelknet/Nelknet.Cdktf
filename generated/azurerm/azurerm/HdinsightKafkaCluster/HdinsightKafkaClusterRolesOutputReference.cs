using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesOutputReference), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightKafkaClusterRolesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightKafkaClusterRolesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightKafkaClusterRolesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightKafkaClusterRolesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHeadNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNode\"}}]")]
        public virtual void PutHeadNode(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaManagementNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNode\"}}]")]
        public virtual void PutKafkaManagementNode(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkerNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNode\"}}]")]
        public virtual void PutWorkerNode(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZookeeperNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNode\"}}]")]
        public virtual void PutZookeeperNode(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKafkaManagementNode")]
        public virtual void ResetKafkaManagementNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNodeOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNodeOutputReference HeadNode
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNodeOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaManagementNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNodeOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNodeOutputReference KafkaManagementNode
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNodeOutputReference>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNodeOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNodeOutputReference WorkerNode
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNodeOutputReference>()!;
        }

        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNodeOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNodeOutputReference ZookeeperNode
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode? HeadNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaManagementNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode? KafkaManagementNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode? WorkerNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zookeeperNodeInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNode\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode? ZookeeperNodeInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles?>();
            set => SetInstanceProperty(value);
        }
    }
}
