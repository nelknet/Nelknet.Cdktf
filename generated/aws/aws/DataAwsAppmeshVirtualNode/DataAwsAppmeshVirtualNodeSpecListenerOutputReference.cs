using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshVirtualNodeSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshVirtualNodeSpecListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualNodeSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualNodeSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolList ConnectionPool
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolList>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerHealthCheckList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerHealthCheckList HealthCheck
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerHealthCheckList>()!;
        }

        [JsiiProperty(name: "outlierDetection", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerOutlierDetectionList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerOutlierDetectionList OutlierDetection
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerOutlierDetectionList>()!;
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerPortMappingList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerPortMappingList PortMapping
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerPortMappingList>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTimeoutList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTimeoutList Timeout
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTimeoutList>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTlsList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTlsList Tls
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerTlsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecListener? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
