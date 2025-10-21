using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteOutputReference), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshGatewayRouteSpecHttp2RouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshGatewayRouteSpecHttp2RouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteAction\"}}]")]
        public virtual void PutAction(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatch\"}}]")]
        public virtual void PutMatch(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteAction\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteMatch\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2Route? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2Route?>();
            set => SetInstanceProperty(value);
        }
    }
}
