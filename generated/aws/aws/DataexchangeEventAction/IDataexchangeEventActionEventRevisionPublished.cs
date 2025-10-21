using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiInterface(nativeType: typeof(IDataexchangeEventActionEventRevisionPublished), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished")]
    public interface IDataexchangeEventActionEventRevisionPublished
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#data_set_id DataexchangeEventAction#data_set_id}.</summary>
        [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataexchangeEventActionEventRevisionPublished), fullyQualifiedName: "aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished")]
        internal sealed class _Proxy : DeputyBase, aws.DataexchangeEventAction.IDataexchangeEventActionEventRevisionPublished
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#data_set_id DataexchangeEventAction#data_set_id}.</summary>
            [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
