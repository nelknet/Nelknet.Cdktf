using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiInterface(nativeType: typeof(IDataexchangeEventActionActionExportRevisionToS3), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3")]
    public interface IDataexchangeEventActionActionExportRevisionToS3
    {
        /// <summary>encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#encryption DataexchangeEventAction#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3Encryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Encryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>revision_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_destination DataexchangeEventAction#revision_destination}
        /// </remarks>
        [JsiiProperty(name: "revisionDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RevisionDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeEventActionActionExportRevisionToS3), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#encryption DataexchangeEventAction#encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3Encryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Encryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>revision_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_destination DataexchangeEventAction#revision_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revisionDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RevisionDestination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
