using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRewrite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewrite\"}}]")]
        public virtual void PutRewrite(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}}]")]
        public virtual void PutTarget(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRewrite")]
        public virtual void ResetRewrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewriteOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewriteOutputReference Rewrite
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewriteOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference Target
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rewriteInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionRewrite\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite? RewriteInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionRewrite?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget? TargetInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteAction\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
