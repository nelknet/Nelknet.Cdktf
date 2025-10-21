using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    [JsiiByValue(fqn: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpec")]
    public class AppmeshVirtualRouterSpec : aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpec
    {
        private object? _listener;

        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Listener
        {
            get => _listener;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _listener = value;
            }
        }
    }
}
