using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComponentVersionOutputReference), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHadoopClusterComponentVersionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHadoopClusterComponentVersionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHadoopClusterComponentVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHadoopClusterComponentVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "hadoopInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HadoopInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hadoop", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hadoop
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion\"}", isOptional: true)]
        public virtual azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
