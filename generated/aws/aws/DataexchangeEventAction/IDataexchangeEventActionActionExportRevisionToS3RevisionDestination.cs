using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiInterface(nativeType: typeof(IDataexchangeEventActionActionExportRevisionToS3RevisionDestination), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination")]
    public interface IDataexchangeEventActionActionExportRevisionToS3RevisionDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#bucket DataexchangeEventAction#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#key_pattern DataexchangeEventAction#key_pattern}.</summary>
        [JsiiProperty(name: "keyPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyPattern
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeEventActionActionExportRevisionToS3RevisionDestination), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3RevisionDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#bucket DataexchangeEventAction#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#key_pattern DataexchangeEventAction#key_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyPattern
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
