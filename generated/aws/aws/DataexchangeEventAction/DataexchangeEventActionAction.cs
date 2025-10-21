using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiByValue(fqn: "aws.dataexchangeEventAction.DataexchangeEventActionAction")]
    public class DataexchangeEventActionAction : aws.DataexchangeEventAction.IDataexchangeEventActionAction
    {
        private object? _exportRevisionToS3;

        /// <summary>export_revision_to_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#export_revision_to_s3 DataexchangeEventAction#export_revision_to_s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportRevisionToS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExportRevisionToS3
        {
            get => _exportRevisionToS3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exportRevisionToS3 = value;
            }
        }
    }
}
