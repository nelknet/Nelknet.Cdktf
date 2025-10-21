using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorKafkaClusterApacheKafkaClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpc\"}}]")]
        public virtual void PutVpc(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc)}, new object[]{@value});
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpcOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpcOutputReference Vpc
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpcOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapServersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootstrapServersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpc\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc? VpcInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc?>();
        }

        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapServers
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
