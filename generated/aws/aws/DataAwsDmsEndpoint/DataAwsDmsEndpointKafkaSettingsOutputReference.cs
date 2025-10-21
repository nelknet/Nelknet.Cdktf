using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDmsEndpoint
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettingsOutputReference), fullyQualifiedName: "aws.dataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDmsEndpointKafkaSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDmsEndpointKafkaSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsDmsEndpointKafkaSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpointKafkaSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Broker
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeControlDetails", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludeControlDetails
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "includeNullAndEmpty", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludeNullAndEmpty
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "includePartitionValue", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludePartitionValue
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "includeTableAlterOperations", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludeTableAlterOperations
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "includeTransactionDetails", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IncludeTransactionDetails
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "messageMaxBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessageMaxBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "noHexPrefix", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable NoHexPrefix
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "partitionIncludeSchemaTable", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PartitionIncludeSchemaTable
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslCaCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCaCertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientCertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeyArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslClientKeyPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslClientKeyPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettings\"}", isOptional: true)]
        public virtual aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointKafkaSettings? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointKafkaSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
