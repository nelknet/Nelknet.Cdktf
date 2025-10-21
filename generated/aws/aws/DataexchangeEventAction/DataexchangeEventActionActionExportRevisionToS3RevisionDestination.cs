using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataexchangeEventAction.DataexchangeEventActionActionExportRevisionToS3RevisionDestination")]
    public class DataexchangeEventActionActionExportRevisionToS3RevisionDestination : aws.DataexchangeEventAction.IDataexchangeEventActionActionExportRevisionToS3RevisionDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#bucket DataexchangeEventAction#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#key_pattern DataexchangeEventAction#key_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPattern
        {
            get;
            set;
        }
    }
}
