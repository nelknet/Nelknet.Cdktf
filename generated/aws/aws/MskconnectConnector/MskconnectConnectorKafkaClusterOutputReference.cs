using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorKafkaClusterOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorKafkaClusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorKafkaClusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorKafkaClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorKafkaClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApacheKafkaCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster\"}}]")]
        public virtual void PutApacheKafkaCluster(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster)}, new object[]{@value});
        }

        [JsiiProperty(name: "apacheKafkaCluster", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference ApacheKafkaCluster
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apacheKafkaClusterInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster? ApacheKafkaClusterInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaCluster\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaCluster? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaCluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
