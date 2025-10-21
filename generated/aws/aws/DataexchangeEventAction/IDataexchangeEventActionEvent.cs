using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiInterface(nativeType: typeof(IDataexchangeEventActionEvent), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionEvent")]
    public interface IDataexchangeEventActionEvent
    {
        /// <summary>revision_published block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_published DataexchangeEventAction#revision_published}
        /// </remarks>
        [JsiiProperty(name: "revisionPublished", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RevisionPublished
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeEventActionEvent), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionEvent")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeEventAction.IDataexchangeEventActionEvent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>revision_published block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_published DataexchangeEventAction#revision_published}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revisionPublished", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RevisionPublished
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
