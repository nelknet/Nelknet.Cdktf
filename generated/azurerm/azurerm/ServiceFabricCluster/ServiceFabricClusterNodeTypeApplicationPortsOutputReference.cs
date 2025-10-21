using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricClusterNodeTypeApplicationPortsOutputReference), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPortsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricClusterNodeTypeApplicationPortsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricClusterNodeTypeApplicationPortsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceFabricClusterNodeTypeApplicationPortsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterNodeTypeApplicationPortsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "endPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EndPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "endPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts?>();
            set => SetInstanceProperty(value);
        }
    }
}
