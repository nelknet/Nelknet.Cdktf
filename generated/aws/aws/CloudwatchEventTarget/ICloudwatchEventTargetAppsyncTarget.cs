using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetAppsyncTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget")]
    public interface ICloudwatchEventTargetAppsyncTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#graphql_operation CloudwatchEventTarget#graphql_operation}.</summary>
        [JsiiProperty(name: "graphqlOperation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GraphqlOperation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetAppsyncTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#graphql_operation CloudwatchEventTarget#graphql_operation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "graphqlOperation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GraphqlOperation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
