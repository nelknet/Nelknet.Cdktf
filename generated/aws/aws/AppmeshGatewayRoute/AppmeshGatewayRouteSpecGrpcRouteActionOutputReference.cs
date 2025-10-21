using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshGatewayRouteSpecGrpcRouteActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}}]")]
        public virtual void PutTarget(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteActionTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteActionTarget)}, new object[]{@value});
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference Target
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteActionTarget? TargetInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteActionTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecGrpcRouteAction\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecGrpcRouteAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
