using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}}]")]
        public virtual void PutGrpc(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}}]")]
        public virtual void PutHttp(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}}]")]
        public virtual void PutHttp2(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpc")]
        public virtual void ResetGrpc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp2")]
        public virtual void ResetHttp2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference Grpc
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference Http
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference>()!;
        }

        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference Http2
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? GrpcInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2Input", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2Input
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? HttpInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPool? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListenerConnectionPool?>();
            set => SetInstanceProperty(value);
        }
    }
}
