using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiByValue(fqn: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3")]
    public class DataexchangeEventActionActionExportRevisionToS3 : aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3
    {
        private object? _encryption;

        /// <summary>encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#encryption DataexchangeEventAction#encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3Encryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Encryption
        {
            get => _encryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3Encryption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3Encryption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _encryption = value;
            }
        }

        private object? _revisionDestination;

        /// <summary>revision_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_destination DataexchangeEventAction#revision_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RevisionDestination
        {
            get => _revisionDestination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3RevisionDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3RevisionDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _revisionDestination = value;
            }
        }
    }
}
