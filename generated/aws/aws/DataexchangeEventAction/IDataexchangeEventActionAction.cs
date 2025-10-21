using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiInterface(nativeType: typeof(IDataexchangeEventActionAction), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionAction")]
    public interface IDataexchangeEventActionAction
    {
        /// <summary>export_revision_to_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#export_revision_to_s3 DataexchangeEventAction#export_revision_to_s3}
        /// </remarks>
        [JsiiProperty(name: "exportRevisionToS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExportRevisionToS3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeEventActionAction), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeEventAction.IDataexchangeEventActionAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>export_revision_to_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#export_revision_to_s3 DataexchangeEventAction#export_revision_to_s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exportRevisionToS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExportRevisionToS3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
