using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished")]
    public class DataexchangeEventActionEventRevisionPublished : aws.DataexchangeEventAction.IDataexchangeEventActionEventRevisionPublished
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#data_set_id DataexchangeEventAction#data_set_id}.</summary>
        [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetId
        {
            get;
            set;
        }
    }
}
