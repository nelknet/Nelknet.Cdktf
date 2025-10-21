using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingOutputReference), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualGatewaySpecLoggingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualGatewaySpecLoggingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualGatewaySpecLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLog\"}}]")]
        public virtual void PutAccessLog(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLog")]
        public virtual void ResetAccessLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference AccessLog
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLogInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLogInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
