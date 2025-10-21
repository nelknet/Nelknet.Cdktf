using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolGrpcList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolGrpcList Grpc
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolGrpcList>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttpList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttpList Http
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttpList>()!;
        }

        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttp2List\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttp2List Http2
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolHttp2List>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolTcpList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolTcpList Tcp
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPoolTcpList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecListenerConnectionPool? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecListenerConnectionPool?>();
            set => SetInstanceProperty(value);
        }
    }
}
